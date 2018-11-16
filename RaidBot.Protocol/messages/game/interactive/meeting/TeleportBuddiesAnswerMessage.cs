


















// Generated on 06/26/2015 11:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TeleportBuddiesAnswerMessage : NetworkMessage
{

public const uint Id = 6294;
public override uint MessageId
{
    get { return Id; }
}

public bool accept;
        

public TeleportBuddiesAnswerMessage()
{
}

public TeleportBuddiesAnswerMessage(bool accept)
        {
            this.accept = accept;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(accept);
            

}

public override void Deserialize(ICustomDataReader reader)
{

accept = reader.ReadBoolean();
            

}


}


}