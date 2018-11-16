


















// Generated on 06/26/2015 11:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PaddockSellBuyDialogMessage : NetworkMessage
{

public const uint Id = 6018;
public override uint MessageId
{
    get { return Id; }
}

public bool bsell;
        public uint ownerId;
        public uint price;
        

public PaddockSellBuyDialogMessage()
{
}

public PaddockSellBuyDialogMessage(bool bsell, uint ownerId, uint price)
        {
            this.bsell = bsell;
            this.ownerId = ownerId;
            this.price = price;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(bsell);
            writer.WriteVaruhint(ownerId);
            writer.WriteVaruhint(price);
            

}

public override void Deserialize(ICustomDataReader reader)
{

bsell = reader.ReadBoolean();
            ownerId = reader.ReadVaruhint();
            if (ownerId < 0)
                throw new Exception("Forbidden value on ownerId = " + ownerId + ", it doesn't respect the following condition : ownerId < 0");
            price = reader.ReadVaruhint();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            

}


}


}