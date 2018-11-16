


















// Generated on 06/26/2015 11:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeObjectMovePricedMessage : ExchangeObjectMoveMessage
{

public const uint Id = 5514;
public override uint MessageId
{
    get { return Id; }
}

public uint price;
        

public ExchangeObjectMovePricedMessage()
{
}

public ExchangeObjectMovePricedMessage(uint objectUID, int quantity, uint price)
         : base(objectUID, quantity)
        {
            this.price = price;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(price);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            price = reader.ReadVaruhint();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            

}


}


}