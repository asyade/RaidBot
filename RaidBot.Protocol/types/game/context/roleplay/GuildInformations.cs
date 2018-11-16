


















// Generated on 06/26/2015 11:42:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GuildInformations : BasicGuildInformations
{

public const short Id = 127;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildEmblem guildEmblem;
        

public GuildInformations()
{
}

public GuildInformations(uint guildId, string guildName, Types.GuildEmblem guildEmblem)
         : base(guildId, guildName)
        {
            this.guildEmblem = guildEmblem;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            guildEmblem.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
            

}


}


}