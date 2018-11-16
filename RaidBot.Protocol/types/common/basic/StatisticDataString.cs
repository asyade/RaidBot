


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class StatisticDataString : StatisticData
{

public const short Id = 487;
public override short TypeId
{
    get { return Id; }
}

public string value;
        

public StatisticDataString()
{
}

public StatisticDataString(ushort actionId, string value)
         : base(actionId)
        {
            this.value = value;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(value);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadUTF();
            

}


}


}