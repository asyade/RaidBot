


















// Generated on 06/26/2015 11:40:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IdentificationAccountForceMessage : IdentificationMessage
{

public const uint Id = 6119;
public override uint MessageId
{
    get { return Id; }
}

public string forcedAccountLogin;
        

public IdentificationAccountForceMessage()
{
}

public IdentificationAccountForceMessage(bool autoconnect, bool useCertificate, bool useLoginToken, Types.VersionExtended version, string lang, sbyte[] credentials, short serverId, long sessionOptionalSalt, ushort[] failedAttempts, string forcedAccountLogin)
         : base(autoconnect, useCertificate, useLoginToken, version, lang, credentials, serverId, sessionOptionalSalt, failedAttempts)
        {
            this.forcedAccountLogin = forcedAccountLogin;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(forcedAccountLogin);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            forcedAccountLogin = reader.ReadUTF();
            

}


}


}