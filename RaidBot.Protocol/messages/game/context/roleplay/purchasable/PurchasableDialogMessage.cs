


















// Generated on 06/26/2015 11:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PurchasableDialogMessage : NetworkMessage
{

public const uint Id = 5739;
public override uint MessageId
{
    get { return Id; }
}

public bool buyOrSell;
        public uint purchasableId;
        public uint price;
        

public PurchasableDialogMessage()
{
}

public PurchasableDialogMessage(bool buyOrSell, uint purchasableId, uint price)
        {
            this.buyOrSell = buyOrSell;
            this.purchasableId = purchasableId;
            this.price = price;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(buyOrSell);
            writer.WriteVaruhint(purchasableId);
            writer.WriteVaruhint(price);
            

}

public override void Deserialize(ICustomDataReader reader)
{

buyOrSell = reader.ReadBoolean();
            purchasableId = reader.ReadVaruhint();
            if (purchasableId < 0)
                throw new Exception("Forbidden value on purchasableId = " + purchasableId + ", it doesn't respect the following condition : purchasableId < 0");
            price = reader.ReadVaruhint();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            

}


}


}