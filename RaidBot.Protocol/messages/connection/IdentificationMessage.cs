


















// Generated on 06/26/2015 11:40:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

    public class IdentificationMessage : NetworkMessage
    {
        public const uint Id = 4;
        public override uint MessageId
        {
            get { return Id; }
        }

        public bool autoconnect;
        public bool useCertificate;
        public bool useLoginToken;
        public Types.VersionExtended version;
        public string lang;
        public sbyte[] credentials;
        public short serverId;
        public long sessionOptionalSalt;
        public ushort[] failedAttempts;


        public IdentificationMessage()
        {
        }

        public IdentificationMessage(bool autoconnect, bool useCertificate, bool useLoginToken, Types.VersionExtended version, string lang, sbyte[] credentials, short serverId, long sessionOptionalSalt, ushort[] failedAttempts)
        {
            this.autoconnect = autoconnect;
            this.useCertificate = useCertificate;
            this.useLoginToken = useLoginToken;
            this.version = version;
            this.lang = lang;
            this.credentials = credentials;
            this.serverId = serverId;
            this.sessionOptionalSalt = sessionOptionalSalt;
            this.failedAttempts = failedAttempts;
        }


        public override void Serialize(ICustomDataWriter writer)
        {

            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, autoconnect);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, useCertificate);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, useLoginToken);
            writer.WriteByte(flag1);
            version.Serialize(writer);
            writer.WriteUTF(lang);
            writer.WriteVarint((ushort)credentials.Length);
            foreach (var entry in credentials)
            {
                writer.WriteSByte(entry);
            }
            writer.WriteShort(serverId);
            writer.WriteVarlong(sessionOptionalSalt);
            writer.WriteUShort((ushort)failedAttempts.Length);
            foreach (var entry in failedAttempts)
            {
                writer.WriteVaruhshort(entry);
            }
        }

        public override void Deserialize(ICustomDataReader reader)
        {

            byte flag1 = reader.ReadByte();
            autoconnect = BooleanByteWrapper.GetFlag(flag1, 0);
            useCertificate = BooleanByteWrapper.GetFlag(flag1, 1);
            useLoginToken = BooleanByteWrapper.GetFlag(flag1, 2);
            version = new Types.VersionExtended();
            version.Deserialize(reader);
            lang = reader.ReadUTF();
            var limit = reader.ReadVarint();
            credentials = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                credentials[i] = reader.ReadSByte();
            }
            serverId = reader.ReadShort();
            sessionOptionalSalt = reader.ReadVarlong();
            if (sessionOptionalSalt < -9.007199254740992E15 || sessionOptionalSalt > 9.007199254740992E15)
                throw new Exception("Forbidden value on sessionOptionalSalt = " + sessionOptionalSalt + ", it doesn't respect the following condition : sessionOptionalSalt < -9.007199254740992E15 || sessionOptionalSalt > 9.007199254740992E15");
            limit = reader.ReadUShort();
            failedAttempts = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                failedAttempts[i] = reader.ReadVaruhshort();
            }


        }

    }

}