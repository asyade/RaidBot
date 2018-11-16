


















// Generated on 06/26/2015 11:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class FriendSetWarnOnConnectionMessage : NetworkMessage
{

public const uint Id = 5602;
public override uint MessageId
{
    get { return Id; }
}

public bool enable;
        

public FriendSetWarnOnConnectionMessage()
{
}

public FriendSetWarnOnConnectionMessage(bool enable)
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