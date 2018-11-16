


















// Generated on 06/26/2015 11:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeShopStockMultiMovementUpdatedMessage : NetworkMessage
{

public const uint Id = 6038;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemToSell[] objectInfoList;
        

public ExchangeShopStockMultiMovementUpdatedMessage()
{
}

public ExchangeShopStockMultiMovementUpdatedMessage(Types.ObjectItemToSell[] objectInfoList)
        {
            this.objectInfoList = objectInfoList;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)objectInfoList.Length);
            foreach (var entry in objectInfoList)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            objectInfoList = new Types.ObjectItemToSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectInfoList[i] = new Types.ObjectItemToSell();
                 objectInfoList[i].Deserialize(reader);
            }
            

}


}


}