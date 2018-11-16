


















// Generated on 06/26/2015 11:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectsDeletedMessage : NetworkMessage
{

public const uint Id = 6034;
public override uint MessageId
{
    get { return Id; }
}

public uint[] objectUID;
        

public ObjectsDeletedMessage()
{
}

public ObjectsDeletedMessage(uint[] objectUID)
        {
            this.objectUID = objectUID;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)objectUID.Length);
            foreach (var entry in objectUID)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            objectUID = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectUID[i] = reader.ReadVaruhint();
            }
            

}


}


}