


















// Generated on 06/26/2015 11:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class FriendWarnOnLevelGainStateMessage : NetworkMessage
{

public const uint Id = 6078;
public override uint MessageId
{
    get { return Id; }
}

public bool enable;
        

public FriendWarnOnLevelGainStateMessage()
{
}

public FriendWarnOnLevelGainStateMessage(bool enable)
        {
            this.enable = enable;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(enable);
            

}

public override void Deserialize(ICustomDataReader reader)
{

enable = reader.ReadBoolean();
            

}


}


}