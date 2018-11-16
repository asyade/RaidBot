


















// Generated on 06/26/2015 11:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeShopStockMovementUpdatedMessage : NetworkMessage
{

public const uint Id = 5909;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemToSell objectInfo;
        

public ExchangeShopStockMovementUpdatedMessage()
{
}

public ExchangeShopStockMovementUpdatedMessage(Types.ObjectItemToSell objectInfo)
        {
            this.objectInfo = objectInfo;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

objectInfo.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

objectInfo = new Types.ObjectItemToSell();
            objectInfo.Deserialize(reader);
            

}


}


}