


















// Generated on 06/26/2015 11:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildInformationsMembersMessage : NetworkMessage
{

public const uint Id = 5558;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildMember[] members;
        

public GuildInformationsMembersMessage()
{
}

public GuildInformationsMembersMessage(Types.GuildMember[] members)
        {
            this.members = members;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)members.Length);
            foreach (var entry in members)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            members = new Types.GuildMember[limit];
            for (int i = 0; i < limit; i++)
            {
                 members[i] = new Types.GuildMember();
                 members[i].Deserialize(reader);
            }
            

}


}


}