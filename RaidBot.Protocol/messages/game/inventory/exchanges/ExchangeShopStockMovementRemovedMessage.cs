


















// Generated on 06/26/2015 11:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeShopStockMovementRemovedMessage : NetworkMessage
{

public const uint Id = 5907;
public override uint MessageId
{
    get { return Id; }
}

public uint objectId;
        

public ExchangeShopStockMovementRemovedMessage()
{
}

public ExchangeShopStockMovementRemovedMessage(uint objectId)
        {
            this.objectId = objectId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(objectId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

objectId = reader.ReadVaruhint();
            if (objectId < 0)
                throw new Exception("Forbidden value on objectId = " + objectId + ", it doesn't respect the following condition : objectId < 0");
            

}


}


}