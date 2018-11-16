


















// Generated on 06/26/2015 11:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildModificationNameValidMessage : NetworkMessage
{

public const uint Id = 6327;
public override uint MessageId
{
    get { return Id; }
}

public string guildName;
        

public GuildModificationNameValidMessage()
{
}

public GuildModificationNameValidMessage(string guildName)
        {
            this.guildName = guildName;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(guildName);
            

}

public override void Deserialize(ICustomDataReader reader)
{

guildName = reader.ReadUTF();
            

}


}


}