


















// Generated on 06/26/2015 11:42:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightTeamMemberTaxCollectorInformations : FightTeamMemberInformations
{

public const short Id = 177;
public override short TypeId
{
    get { return Id; }
}

public ushort firstNameId;
        public ushort lastNameId;
        public byte level;
        public uint guildId;
        public uint uid;
        

public FightTeamMemberTaxCollectorInformations()
{
}

public FightTeamMemberTaxCollectorInformations(int id, ushort firstNameId, ushort lastNameId, byte level, uint guildId, uint uid)
         : base(id)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.level = level;
            this.guildId = guildId;
            this.uid = uid;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(firstNameId);
            writer.WriteVaruhshort(lastNameId);
            writer.WriteByte(level);
            writer.WriteVaruhint(guildId);
            writer.WriteVaruhint(uid);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            firstNameId = reader.ReadVaruhshort();
            if (firstNameId < 0)
                throw new Exception("Forbidden value on firstNameId = " + firstNameId + ", it doesn't respect the following condition : firstNameId < 0");
            lastNameId = reader.ReadVaruhshort();
            if (lastNameId < 0)
                throw new Exception("Forbidden value on lastNameId = " + lastNameId + ", it doesn't respect the following condition : lastNameId < 0");
            level = reader.ReadByte();
            if (level < 1 || level > 200)
                throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 1 || level > 200");
            guildId = reader.ReadVaruhint();
            if (guildId < 0)
                throw new Exception("Forbidden value on guildId = " + guildId + ", it doesn't respect the following condition : guildId < 0");
            uid = reader.ReadVaruhint();
            if (uid < 0)
                throw new Exception("Forbidden value on uid = " + uid + ", it doesn't respect the following condition : uid < 0");
            

}


}


}