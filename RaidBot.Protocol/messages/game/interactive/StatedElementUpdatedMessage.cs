


















// Generated on 06/26/2015 11:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class StatedElementUpdatedMessage : NetworkMessage
{

public const uint Id = 5709;
public override uint MessageId
{
    get { return Id; }
}

public Types.StatedElement statedElement;
        

public StatedElementUpdatedMessage()
{
}

public StatedElementUpdatedMessage(Types.StatedElement statedElement)
        {
            this.statedElement = statedElement;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

statedElement.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

statedElement = new Types.StatedElement();
            statedElement.Deserialize(reader);
            

}


}


}