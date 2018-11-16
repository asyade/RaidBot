


















// Generated on 06/26/2015 11:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildInvitationByNameMessage : NetworkMessage
{

public const uint Id = 6115;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        

public GuildInvitationByNameMessage()
{
}

public GuildInvitationByNameMessage(string name)
        {
            this.name = name;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(name);
            

}

public override void Deserialize(ICustomDataReader reader)
{

name = reader.ReadUTF();
            

}


}


}