


















// Generated on 06/26/2015 11:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InventoryWeightMessage : NetworkMessage
{

public const uint Id = 3009;
public override uint MessageId
{
    get { return Id; }
}

public uint weight;
        public uint weightMax;
        

public InventoryWeightMessage()
{
}

public InventoryWeightMessage(uint weight, uint weightMax)
        {
            this.weight = weight;
            this.weightMax = weightMax;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(weight);
            writer.WriteVaruhint(weightMax);
            

}

public override void Deserialize(ICustomDataReader reader)
{

weight = reader.ReadVaruhint();
            if (weight < 0)
                throw new Exception("Forbidden value on weight = " + weight + ", it doesn't respect the following condition : weight < 0");
            weightMax = reader.ReadVaruhint();
            if (weightMax < 0)
                throw new Exception("Forbidden value on weightMax = " + weightMax + ", it doesn't respect the following condition : weightMax < 0");
            

}


}


}