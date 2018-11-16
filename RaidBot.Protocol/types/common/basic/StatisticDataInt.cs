


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class StatisticDataInt : StatisticData
{

public const short Id = 485;
public override short TypeId
{
    get { return Id; }
}

public int value;
        

public StatisticDataInt()
{
}

public StatisticDataInt(ushort actionId, int value)
         : base(actionId)
        {
            this.value = value;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(value);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadInt();
            

}


}


}