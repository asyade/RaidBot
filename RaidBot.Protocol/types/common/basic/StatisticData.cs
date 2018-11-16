


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class StatisticData
{

public const short Id = 484;
public virtual short TypeId
{
    get { return Id; }
}

public ushort actionId;
        

public StatisticData()
{
}

public StatisticData(ushort actionId)
        {
            this.actionId = actionId;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(actionId);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

actionId = reader.ReadVaruhshort();
            if (actionId < 0)
                throw new Exception("Forbidden value on actionId = " + actionId + ", it doesn't respect the following condition : actionId < 0");
            

}


}


}