


















// Generated on 06/26/2015 11:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeWeightMessage : NetworkMessage
{

public const uint Id = 5793;
public override uint MessageId
{
    get { return Id; }
}

public uint currentWeight;
        public uint maxWeight;
        

public ExchangeWeightMessage()
{
}

public ExchangeWeightMessage(uint currentWeight, uint maxWeight)
        {
            this.currentWeight = currentWeight;
            this.maxWeight = maxWeight;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(currentWeight);
            writer.WriteVaruhint(maxWeight);
            

}

public override void Deserialize(ICustomDataReader reader)
{

currentWeight = reader.ReadVaruhint();
            if (currentWeight < 0)
                throw new Exception("Forbidden value on currentWeight = " + currentWeight + ", it doesn't respect the following condition : currentWeight < 0");
            maxWeight = reader.ReadVaruhint();
            if (maxWeight < 0)
                throw new Exception("Forbidden value on maxWeight = " + maxWeight + ", it doesn't respect the following condition : maxWeight < 0");
            

}


}


}