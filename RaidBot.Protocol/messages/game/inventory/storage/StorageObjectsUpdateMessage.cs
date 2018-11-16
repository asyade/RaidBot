


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class StorageObjectsUpdateMessage : NetworkMessage
{

public const uint Id = 6036;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objectList;
        

public StorageObjectsUpdateMessage()
{
}

public StorageObjectsUpdateMessage(Types.ObjectItem[] objectList)
        {
            this.objectList = objectList;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)objectList.Length);
            foreach (var entry in objectList)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            objectList = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectList[i] = new Types.ObjectItem();
                 objectList[i].Deserialize(reader);
            }
            

}


}


}