


















// Generated on 06/26/2015 11:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeCraftPaymentModificationRequestMessage : NetworkMessage
{

public const uint Id = 6579;
public override uint MessageId
{
    get { return Id; }
}

public uint quantity;
        

public ExchangeCraftPaymentModificationRequestMessage()
{
}

public ExchangeCraftPaymentModificationRequestMessage(uint quantity)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(quantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

quantity = reader.ReadVaruhint();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}