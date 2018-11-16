


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class StorageObjectRemoveMessage : NetworkMessage
{

public const uint Id = 5648;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        

public StorageObjectRemoveMessage()
{
}

public StorageObjectRemoveMessage(uint objectUID)
        {
            this.objectUID = objectUID;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(objectUID);
            

}

public override void Deserialize(ICustomDataReader reader)
{

objectUID = reader.ReadVaruhint();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            

}


}


}