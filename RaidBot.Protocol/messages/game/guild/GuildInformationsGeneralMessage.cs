


















// Generated on 06/26/2015 11:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildInformationsGeneralMessage : NetworkMessage
{

public const uint Id = 5557;
public override uint MessageId
{
    get { return Id; }
}

public bool enabled;
        public bool abandonnedPaddock;
        public byte level;
        public ulong expLevelFloor;
        public ulong experience;
        public ulong expNextLevelFloor;
        public int creationDate;
        public ushort nbTotalMembers;
        public ushort nbConnectedMembers;
        

public GuildInformationsGeneralMessage()
{
}

public GuildInformationsGeneralMessage(bool enabled, bool abandonnedPaddock, byte level, ulong expLevelFloor, ulong experience, ulong expNextLevelFloor, int creationDate, ushort nbTotalMembers, ushort nbConnectedMembers)
        {
            this.enabled = enabled;
            this.abandonnedPaddock = abandonnedPaddock;
            this.level = level;
            this.expLevelFloor = expLevelFloor;
            this.experience = experience;
            this.expNextLevelFloor = expNextLevelFloor;
            this.creationDate = creationDate;
            this.nbTotalMembers = nbTotalMembers;
            this.nbConnectedMembers = nbConnectedMembers;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, enabled);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, abandonnedPaddock);
            writer.WriteByte(flag1);
            writer.WriteByte(level);
            writer.WriteVaruhlong(expLevelFloor);
            writer.WriteVaruhlong(experience);
            writer.WriteVaruhlong(expNextLevelFloor);
            writer.WriteInt(creationDate);
            writer.WriteVaruhshort(nbTotalMembers);
            writer.WriteVaruhshort(nbConnectedMembers);
            

}

public override void Deserialize(ICustomDataReader reader)
{

byte flag1 = reader.ReadByte();
            enabled = BooleanByteWrapper.GetFlag(flag1, 0);
            abandonnedPaddock = BooleanByteWrapper.GetFlag(flag1, 1);
            level = reader.ReadByte();
            if (level < 0 || level > 255)
                throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 0 || level > 255");
            expLevelFloor = reader.ReadVaruhlong();
            if (expLevelFloor < 0 || expLevelFloor > 9.007199254740992E15)
                throw new Exception("Forbidden value on expLevelFloor = " + expLevelFloor + ", it doesn't respect the following condition : expLevelFloor < 0 || expLevelFloor > 9.007199254740992E15");
            experience = reader.ReadVaruhlong();
            if (experience < 0 || experience > 9.007199254740992E15)
                throw new Exception("Forbidden value on experience = " + experience + ", it doesn't respect the following condition : experience < 0 || experience > 9.007199254740992E15");
            expNextLevelFloor = reader.ReadVaruhlong();
            if (expNextLevelFloor < 0 || expNextLevelFloor > 9.007199254740992E15)
                throw new Exception("Forbidden value on expNextLevelFloor = " + expNextLevelFloor + ", it doesn't respect the following condition : expNextLevelFloor < 0 || expNextLevelFloor > 9.007199254740992E15");
            creationDate = reader.ReadInt();
            if (creationDate < 0)
                throw new Exception("Forbidden value on creationDate = " + creationDate + ", it doesn't respect the following condition : creationDate < 0");
            nbTotalMembers = reader.ReadVaruhshort();
            if (nbTotalMembers < 0)
                throw new Exception("Forbidden value on nbTotalMembers = " + nbTotalMembers + ", it doesn't respect the following condition : nbTotalMembers < 0");
            nbConnectedMembers = reader.ReadVaruhshort();
            if (nbConnectedMembers < 0)
                throw new Exception("Forbidden value on nbConnectedMembers = " + nbConnectedMembers + ", it doesn't respect the following condition : nbConnectedMembers < 0");
            

}


}


}