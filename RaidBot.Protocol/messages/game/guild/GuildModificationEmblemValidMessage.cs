


















// Generated on 06/26/2015 11:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildModificationEmblemValidMessage : NetworkMessage
{

public const uint Id = 6328;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildEmblem guildEmblem;
        

public GuildModificationEmblemValidMessage()
{
}

public GuildModificationEmblemValidMessage(Types.GuildEmblem guildEmblem)
        {
            this.guildEmblem = guildEmblem;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

guildEmblem.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
            

}


}


}