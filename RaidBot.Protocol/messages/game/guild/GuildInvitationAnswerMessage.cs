


















// Generated on 06/26/2015 11:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildInvitationAnswerMessage : NetworkMessage
{

public const uint Id = 5556;
public override uint MessageId
{
    get { return Id; }
}

public bool accept;
        

public GuildInvitationAnswerMessage()
{
}

public GuildInvitationAnswerMessage(bool accept)
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