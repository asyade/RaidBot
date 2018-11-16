


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InteractiveElementUpdatedMessage : NetworkMessage
{

public const uint Id = 5708;
public override uint MessageId
{
    get { return Id; }
}

public Types.InteractiveElement interactiveElement;
        

public InteractiveElementUpdatedMessage()
{
}

public InteractiveElementUpdatedMessage(Types.InteractiveElement interactiveElement)
        {
            this.interactiveElement = interactiveElement;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

interactiveElement.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

interactiveElement = new Types.InteractiveElement();
            interactiveElement.Deserialize(reader);
            

}


}


}