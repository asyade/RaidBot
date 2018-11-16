


















// Generated on 06/26/2015 11:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildModificationValidMessage : NetworkMessage
{

public const uint Id = 6323;
public override uint MessageId
{
    get { return Id; }
}

public string guildName;
        public Types.GuildEmblem guildEmblem;
        

public GuildModificationValidMessage()
{
}

public GuildModificationValidMessage(string guildName, Types.GuildEmblem guildEmblem)
        {
            this.guildName = guildName;
            this.guildEmblem = guildEmblem;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(guildName);
            guildEmblem.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

guildName = reader.ReadUTF();
            guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
            

}


}


}