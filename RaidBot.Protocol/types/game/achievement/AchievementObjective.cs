


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AchievementObjective
{

public const short Id = 404;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        public ushort maxValue;
        

public AchievementObjective()
{
}

public AchievementObjective(uint id, ushort maxValue)
        {
            this.id = id;
            this.maxValue = maxValue;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(id);
            writer.WriteVaruhshort(maxValue);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

id = reader.ReadVaruhint();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            maxValue = reader.ReadVaruhshort();
            if (maxValue < 0)
                throw new Exception("Forbidden value on maxValue = " + maxValue + ", it doesn't respect the following condition : maxValue < 0");
            

}


}


}