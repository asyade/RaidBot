


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class StatisticDataBoolean : StatisticData
{

public const short Id = 482;
public override short TypeId
{
    get { return Id; }
}

public bool value;
        

public StatisticDataBoolean()
{
}

public StatisticDataBoolean(ushort actionId, bool value)
         : base(actionId)
        {
            this.value = value;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(value);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadBoolean();
            

}


}


}