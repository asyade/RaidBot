


















// Generated on 06/26/2015 11:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildFactsRequestMessage : NetworkMessage
{

public const uint Id = 6404;
public override uint MessageId
{
    get { return Id; }
}

public uint guildId;
        

public GuildFactsRequestMessage()
{
}

public GuildFactsRequestMessage(uint guildId)
        {
            this.guildId = guildId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(guildId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

guildId = reader.ReadVaruhint();
            if (guildId < 0)
                throw new Exception("Forbidden value on guildId = " + guildId + ", it doesn't respect the following condition : guildId < 0");
            

}


}


}