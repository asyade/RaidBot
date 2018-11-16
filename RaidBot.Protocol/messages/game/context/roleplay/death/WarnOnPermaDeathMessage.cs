


















// Generated on 06/26/2015 11:41:22
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class WarnOnPermaDeathMessage : NetworkMessage
{

public const uint Id = 6512;
public override uint MessageId
{
    get { return Id; }
}

public bool enable;
        

public WarnOnPermaDeathMessage()
{
}

public WarnOnPermaDeathMessage(bool enable)
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