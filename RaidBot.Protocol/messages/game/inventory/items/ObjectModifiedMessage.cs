


















// Generated on 06/26/2015 11:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectModifiedMessage : NetworkMessage
{

public const uint Id = 3029;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem @object;
        

public ObjectModifiedMessage()
{
}

public ObjectModifiedMessage(Types.ObjectItem @object)
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