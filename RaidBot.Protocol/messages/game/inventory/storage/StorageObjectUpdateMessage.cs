


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class StorageObjectUpdateMessage : NetworkMessage
{

public const uint Id = 5647;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem @object;
        

public StorageObjectUpdateMessage()
{
}

public StorageObjectUpdateMessage(Types.ObjectItem @object)
        {
            this.@object = @object;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

@object.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

@object = new Types.ObjectItem();
            @object.Deserialize(reader);
            

}


}


}