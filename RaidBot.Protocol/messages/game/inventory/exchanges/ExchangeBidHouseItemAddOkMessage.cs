


















// Generated on 06/26/2015 11:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeBidHouseItemAddOkMessage : NetworkMessage
{

public const uint Id = 5945;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemToSellInBid itemInfo;
        

public ExchangeBidHouseItemAddOkMessage()
{
}

public ExchangeBidHouseItemAddOkMessage(Types.ObjectItemToSellInBid itemInfo)
        {
            this.itemInfo = itemInfo;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

itemInfo.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

itemInfo = new Types.ObjectItemToSellInBid();
            itemInfo.Deserialize(reader);
            

}


}


}