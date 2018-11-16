


















// Generated on 06/26/2015 11:41:20
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PaddockBuyResultMessage : NetworkMessage
{

public const uint Id = 6516;
public override uint MessageId
{
    get { return Id; }
}

public int paddockId;
        public bool bought;
        public uint realPrice;
        

public PaddockBuyResultMessage()
{
}

public PaddockBuyResultMessage(int paddockId, bool bought, uint realPrice)
        {
            this.paddockId = paddockId;
            this.bought = bought;
            this.realPrice = realPrice;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(paddockId);
            writer.WriteBoolean(bought);
            writer.WriteVaruhint(realPrice);
            

}

public override void Deserialize(ICustomDataReader reader)
{

paddockId = reader.ReadInt();
            bought = reader.ReadBoolean();
            realPrice = reader.ReadVaruhint();
            if (realPrice < 0)
                throw new Exception("Forbidden value on realPrice = " + realPrice + ", it doesn't respect the following condition : realPrice < 0");
            

}


}


}