


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class StatisticDataShort : StatisticData
{

public const short Id = 488;
public override short TypeId
{
    get { return Id; }
}

public short value;
        

public StatisticDataShort()
{
}

public StatisticDataShort(ushort actionId, short value)
         : base(actionId)
        {
            this.value = value;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(value);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadShort();
            

}


}


}