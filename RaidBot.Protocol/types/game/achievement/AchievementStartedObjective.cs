


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AchievementStartedObjective : AchievementObjective
{

public const short Id = 402;
public override short TypeId
{
    get { return Id; }
}

public ushort value;
        

public AchievementStartedObjective()
{
}

public AchievementStartedObjective(uint id, ushort maxValue, ushort value)
         : base(id, maxValue)
        {
            this.value = value;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(value);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadVaruhshort();
            if (value < 0)
                throw new Exception("Forbidden value on value = " + value + ", it doesn't respect the following condition : value < 0");
            

}


}


}