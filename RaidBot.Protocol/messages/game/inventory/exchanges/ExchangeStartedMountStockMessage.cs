


















// Generated on 06/26/2015 11:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeStartedMountStockMessage : NetworkMessage
{

public const uint Id = 5984;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objectsInfos;
        

public ExchangeStartedMountStockMessage()
{
}

public ExchangeStartedMountStockMessage(Types.ObjectItem[] objectsInfos)
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
            objectsInfos = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos[i] = new Types.ObjectItem();
                 objectsInfos[i].Deserialize(reader);
            }
            

}


}


}