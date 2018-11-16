


















// Generated on 06/26/2015 11:42:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class SkillActionDescriptionCollect : SkillActionDescriptionTimed
{

public const short Id = 99;
public override short TypeId
{
    get { return Id; }
}

public ushort min;
        public ushort max;
        

public SkillActionDescriptionCollect()
{
}

public SkillActionDescriptionCollect(ushort skillId, byte time, ushort min, ushort max)
         : base(skillId, time)
        {
            this.min = min;
            this.max = max;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(min);
            writer.WriteVaruhshort(max);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            min = reader.ReadVaruhshort();
            if (min < 0)
                throw new Exception("Forbidden value on min = " + min + ", it doesn't respect the following condition : min < 0");
            max = reader.ReadVaruhshort();
            if (max < 0)
                throw new Exception("Forbidden value on max = " + max + ", it doesn't respect the following condition : max < 0");
            

}


}


}