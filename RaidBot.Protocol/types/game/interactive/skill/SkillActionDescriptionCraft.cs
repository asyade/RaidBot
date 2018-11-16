


















// Generated on 06/26/2015 11:42:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class SkillActionDescriptionCraft : SkillActionDescription
{

public const short Id = 100;
public override short TypeId
{
    get { return Id; }
}

public sbyte probability;
        

public SkillActionDescriptionCraft()
{
}

public SkillActionDescriptionCraft(ushort skillId, sbyte probability)
         : base(skillId)
        {
            this.probability = probability;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(probability);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            probability = reader.ReadSByte();
            if (probability < 0)
                throw new Exception("Forbidden value on probability = " + probability + ", it doesn't respect the following condition : probability < 0");
            

}


}


}