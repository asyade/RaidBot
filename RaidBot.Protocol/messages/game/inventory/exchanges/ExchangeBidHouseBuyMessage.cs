


















// Generated on 06/26/2015 11:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeBidHouseBuyMessage : NetworkMessage
{

public const uint Id = 5804;
public override uint MessageId
{
    get { return Id; }
}

public uint uid;
        public uint qty;
        public uint price;
        

public ExchangeBidHouseBuyMessage()
{
}

public ExchangeBidHouseBuyMessage(uint uid, uint qty, uint price)
        {
            this.uid = uid;
            this.qty = qty;
            this.price = price;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(uid);
            writer.WriteVaruhint(qty);
            writer.WriteVaruhint(price);
            

}

public override void Deserialize(ICustomDataReader reader)
{

uid = reader.ReadVaruhint();
            if (uid < 0)
                throw new Exception("Forbidden value on uid = " + uid + ", it doesn't respect the following condition : uid < 0");
            qty = reader.ReadVaruhint();
            if (qty < 0)
                throw new Exception("Forbidden value on qty = " + qty + ", it doesn't respect the following condition : qty < 0");
            price = reader.ReadVaruhint();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            

}


}


}