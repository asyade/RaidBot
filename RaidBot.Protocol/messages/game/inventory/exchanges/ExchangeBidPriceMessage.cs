


















// Generated on 06/26/2015 11:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeBidPriceMessage : NetworkMessage
{

public const uint Id = 5755;
public override uint MessageId
{
    get { return Id; }
}

public ushort genericId;
        public int averagePrice;
        

public ExchangeBidPriceMessage()
{
}

public ExchangeBidPriceMessage(ushort genericId, int averagePrice)
        {
            this.genericId = genericId;
            this.averagePrice = averagePrice;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(genericId);
            writer.WriteVarint(averagePrice);
            

}

public override void Deserialize(ICustomDataReader reader)
{

genericId = reader.ReadVaruhshort();
            if (genericId < 0)
                throw new Exception("Forbidden value on genericId = " + genericId + ", it doesn't respect the following condition : genericId < 0");
            averagePrice = reader.ReadVarint();
            

}


}


}