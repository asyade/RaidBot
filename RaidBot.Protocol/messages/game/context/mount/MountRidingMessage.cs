


















// Generated on 06/26/2015 11:41:19
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MountRidingMessage : NetworkMessage
{

public const uint Id = 5967;
public override uint MessageId
{
    get { return Id; }
}

public bool isRiding;
        

public MountRidingMessage()
{
}

public MountRidingMessage(bool isRiding)
        {
            this.isRiding = isRiding;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(isRiding);
            

}

public override void Deserialize(ICustomDataReader reader)
{

isRiding = reader.ReadBoolean();
            

}


}


}