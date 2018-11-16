


















// Generated on 06/26/2015 11:41:24
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class HouseBuyResultMessage : NetworkMessage
{

public const uint Id = 5735;
public override uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public bool bought;
        public uint realPrice;
        

public HouseBuyResultMessage()
{
}

public HouseBuyResultMessage(uint houseId, bool bought, uint realPrice)
        {
            this.houseId = houseId;
            this.bought = bought;
            this.realPrice = realPrice;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(houseId);
            writer.WriteBoolean(bought);
            writer.WriteVaruhint(realPrice);
            

}

public override void Deserialize(ICustomDataReader reader)
{

houseId = reader.ReadVaruhint();
            if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            bought = reader.ReadBoolean();
            realPrice = reader.ReadVaruhint();
            if (realPrice < 0)
                throw new Exception("Forbidden value on realPrice = " + realPrice + ", it doesn't respect the following condition : realPrice < 0");
            

}


}


}