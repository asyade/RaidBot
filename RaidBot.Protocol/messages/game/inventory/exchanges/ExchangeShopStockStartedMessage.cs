


















// Generated on 06/26/2015 11:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeShopStockStartedMessage : NetworkMessage
{

public const uint Id = 5910;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemToSell[] objectsInfos;
        

public ExchangeShopStockStartedMessage()
{
}

public ExchangeShopStockStartedMessage(Types.ObjectItemToSell[] objectsInfos)
        {
            this.objectsInfos = objectsInfos;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)objectsInfos.Length);
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            objectsInfos = new Types.ObjectItemToSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos[i] = new Types.ObjectItemToSell();
                 objectsInfos[i].Deserialize(reader);
            }
            

}


}


}