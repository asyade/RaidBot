


















// Generated on 06/26/2015 11:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeSellMessage : NetworkMessage
{

public const uint Id = 5778;
public override uint MessageId
{
    get { return Id; }
}

public uint objectToSellId;
        public uint quantity;
        

public ExchangeSellMessage()
{
}

public ExchangeSellMessage(uint objectToSellId, uint quantity)
        {
            this.objectToSellId = objectToSellId;
            this.quantity = quantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(objectToSellId);
            writer.WriteVaruhint(quantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

objectToSellId = reader.ReadVaruhint();
            if (objectToSellId < 0)
                throw new Exception("Forbidden value on objectToSellId = " + objectToSellId + ", it doesn't respect the following condition : objectToSellId < 0");
            quantity = reader.ReadVaruhint();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}