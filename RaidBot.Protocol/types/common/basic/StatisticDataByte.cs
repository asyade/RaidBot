


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class StatisticDataByte : StatisticData
{

public const short Id = 486;
public override short TypeId
{
    get { return Id; }
}

public sbyte value;
        

public StatisticDataByte()
{
}

public StatisticDataByte(ushort actionId, sbyte value)
         : base(actionId)
        {
            this.value = value;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(value);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadSByte();
            

}


}


}