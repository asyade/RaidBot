


















// Generated on 06/26/2015 11:41:24
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class HouseSoldMessage : NetworkMessage
{

public const uint Id = 5737;
public override uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public uint realPrice;
        public string buyerName;
        

public HouseSoldMessage()
{
}

public HouseSoldMessage(uint houseId, uint realPrice, string buyerName)
        {
            this.houseId = houseId;
            this.realPrice = realPrice;
            this.buyerName = buyerName;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(houseId);
            writer.WriteVaruhint(realPrice);
            writer.WriteUTF(buyerName);
            

}

public override void Deserialize(ICustomDataReader reader)
{

houseId = reader.ReadVaruhint();
            if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            realPrice = reader.ReadVaruhint();
            if (realPrice < 0)
                throw new Exception("Forbidden value on realPrice = " + realPrice + ", it doesn't respect the following condition : realPrice < 0");
            buyerName = reader.ReadUTF();
            

}


}


}