


















// Generated on 06/26/2015 11:41:56
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class StartupActionAddMessage : NetworkMessage
{

public const uint Id = 6538;
public override uint MessageId
{
    get { return Id; }
}

public Types.StartupActionAddObject newAction;
        

public StartupActionAddMessage()
{
}

public StartupActionAddMessage(Types.StartupActionAddObject newAction)
        {
            this.newAction = newAction;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

newAction.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

newAction = new Types.StartupActionAddObject();
            newAction.Deserialize(reader);
            

}


}


}