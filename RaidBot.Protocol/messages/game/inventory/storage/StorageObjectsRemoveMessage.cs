


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class StorageObjectsRemoveMessage : NetworkMessage
{

public const uint Id = 6035;
public override uint MessageId
{
    get { return Id; }
}

public uint[] objectUIDList;
        

public StorageObjectsRemoveMessage()
{
}

public StorageObjectsRemoveMessage(uint[] objectUIDList)
        {
            this.objectUIDList = objectUIDList;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)objectUIDList.Length);
            foreach (var entry in objectUIDList)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            objectUIDList = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectUIDList[i] = reader.ReadVaruhint();
            }
            

}


}


}