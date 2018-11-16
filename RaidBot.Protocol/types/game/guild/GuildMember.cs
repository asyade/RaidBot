


















// Generated on 06/26/2015 11:42:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GuildMember : CharacterMinimalInformations
{

public const short Id = 88;
public override short TypeId
{
    get { return Id; }
}

public sbyte breed;
        public bool sex;
        public ushort rank;
        public ulong givenExperience;
        public sbyte experienceGivenPercent;
        public uint rights;
        public sbyte connected;
        public sbyte alignmentSide;
        public ushort hoursSinceLastConnection;
        public sbyte moodSmileyId;
        public int accountId;
        public int achievementPoints;
        public Types.PlayerStatus status;
        

public GuildMember()
{
}

public GuildMember(uint id, byte level, string name, sbyte breed, bool sex, ushort rank, ulong givenExperience, sbyte experienceGivenPercent, uint rights, sbyte connected, sbyte alignmentSide, ushort hoursSinceLastConnection, sbyte moodSmileyId, int accountId, int achievementPoints, Types.PlayerStatus status)
         : base(id, level, name)
        {
            this.breed = breed;
            this.sex = sex;
            this.rank = rank;
            this.givenExperience = givenExperience;
            this.experienceGivenPercent = experienceGivenPercent;
            this.rights = rights;
            this.connected = connected;
            this.alignmentSide = alignmentSide;
            this.hoursSinceLastConnection = hoursSinceLastConnection;
            this.moodSmileyId = moodSmileyId;
            this.accountId = accountId;
            this.achievementPoints = achievementPoints;
            this.status = status;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteVaruhshort(rank);
            writer.WriteVaruhlong(givenExperience);
            writer.WriteSByte(experienceGivenPercent);
            writer.WriteVaruhint(rights);
            writer.WriteSByte(connected);
            writer.WriteSByte(alignmentSide);
            writer.WriteUShort(hoursSinceLastConnection);
            writer.WriteSByte(moodSmileyId);
            writer.WriteInt(accountId);
            writer.WriteInt(achievementPoints);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
            rank = reader.ReadVaruhshort();
            if (rank < 0)
                throw new Exception("Forbidden value on rank = " + rank + ", it doesn't respect the following condition : rank < 0");
            givenExperience = reader.ReadVaruhlong();
            if (givenExperience < 0 || givenExperience > 9.007199254740992E15)
                throw new Exception("Forbidden value on givenExperience = " + givenExperience + ", it doesn't respect the following condition : givenExperience < 0 || givenExperience > 9.007199254740992E15");
            experienceGivenPercent = reader.ReadSByte();
            if (experienceGivenPercent < 0 || experienceGivenPercent > 100)
                throw new Exception("Forbidden value on experienceGivenPercent = " + experienceGivenPercent + ", it doesn't respect the following condition : experienceGivenPercent < 0 || experienceGivenPercent > 100");
            rights = reader.ReadVaruhint();
            if (rights < 0)
                throw new Exception("Forbidden value on rights = " + rights + ", it doesn't respect the following condition : rights < 0");
            connected = reader.ReadSByte();
            if (connected < 0)
                throw new Exception("Forbidden value on connected = " + connected + ", it doesn't respect the following condition : connected < 0");
            alignmentSide = reader.ReadSByte();
            hoursSinceLastConnection = reader.ReadUShort();
            if (hoursSinceLastConnection < 0 || hoursSinceLastConnection > 65535)
                throw new Exception("Forbidden value on hoursSinceLastConnection = " + hoursSinceLastConnection + ", it doesn't respect the following condition : hoursSinceLastConnection < 0 || hoursSinceLastConnection > 65535");
            moodSmileyId = reader.ReadSByte();
            accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            achievementPoints = reader.ReadInt();
            status = Types.ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadShort());
            status.Deserialize(reader);
            

}


}


}