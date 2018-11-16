


















// Generated on 06/26/2015 11:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeBidHouseInListRemovedMessage : NetworkMessage
{

public const uint Id = 5950;
public override uint MessageId
{
    get { return Id; }
}

public int itemUID;
        

public ExchangeBidHouseInListRemovedMessage()
{
}

public ExchangeBidHouseInListRemovedMessage(int itemUID)
        {
            this.itemUID = itemUID;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(itemUID);
            

}

public override void Deserialize(ICustomDataReader reader)
{

itemUID = reader.ReadInt();
            

}


}


}