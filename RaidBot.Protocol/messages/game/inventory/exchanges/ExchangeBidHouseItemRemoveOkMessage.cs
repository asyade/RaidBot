


















// Generated on 06/26/2015 11:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeBidHouseItemRemoveOkMessage : NetworkMessage
{

public const uint Id = 5946;
public override uint MessageId
{
    get { return Id; }
}

public int sellerId;
        

public ExchangeBidHouseItemRemoveOkMessage()
{
}

public ExchangeBidHouseItemRemoveOkMessage(int sellerId)
        {
            this.sellerId = sellerId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(sellerId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

sellerId = reader.ReadInt();
            

}


}


}