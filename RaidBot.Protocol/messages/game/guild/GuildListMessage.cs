


















// Generated on 06/26/2015 11:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildListMessage : NetworkMessage
{

public const uint Id = 6413;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildInformations[] guilds;
        

public GuildListMessage()
{
}

public GuildListMessage(Types.GuildInformations[] guilds)
        {
            this.guilds = guilds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)guilds.Length);
            foreach (var entry in guilds)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            guilds = new Types.GuildInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = new Types.GuildInformations();
                 guilds[i].Deserialize(reader);
            }
            

}


}


}