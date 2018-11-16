


















// Generated on 06/26/2015 11:41:20
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PaddockSellRequestMessage : NetworkMessage
{

public const uint Id = 5953;
public override uint MessageId
{
    get { return Id; }
}

public uint price;
        

public PaddockSellRequestMessage()
{
}

public PaddockSellRequestMessage(uint price)
        {
            this.price = price;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(price);
            

}

public override void Deserialize(ICustomDataReader reader)
{

price = reader.ReadVaruhint();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            

}


}


}