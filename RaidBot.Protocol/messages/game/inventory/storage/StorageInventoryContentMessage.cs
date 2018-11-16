


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class StorageInventoryContentMessage : InventoryContentMessage
{

public const uint Id = 5646;
public override uint MessageId
{
    get { return Id; }
}



public StorageInventoryContentMessage()
{
}

public StorageInventoryContentMessage(Types.ObjectItem[] objects, uint kamas)
         : base(objects, kamas)
        {
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            

}


}


}