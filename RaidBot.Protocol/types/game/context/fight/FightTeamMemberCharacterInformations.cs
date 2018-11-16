


















// Generated on 06/26/2015 11:42:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightTeamMemberCharacterInformations : FightTeamMemberInformations
{

public const short Id = 13;
public override short TypeId
{
    get { return Id; }
}

public string name;
        public byte level;
        

public FightTeamMemberCharacterInformations()
{
}

public FightTeamMemberCharacterInformations(int id, string name, byte level)
         : base(id)
        {
            this.name = name;
            this.level = level;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteByte(level);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            level = reader.ReadByte();
            if (level < 0 || level > 255)
                throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 0 || level > 255");
            

}


}


}