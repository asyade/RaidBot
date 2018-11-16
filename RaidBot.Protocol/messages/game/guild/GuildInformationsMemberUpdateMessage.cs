


















// Generated on 06/26/2015 11:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildInformationsMemberUpdateMessage : NetworkMessage
{

public const uint Id = 5597;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildMember member;
        

public GuildInformationsMemberUpdateMessage()
{
}

public GuildInformationsMemberUpdateMessage(Types.GuildMember member)
        {
            this.member = member;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

member.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

member = new Types.GuildMember();
            member.Deserialize(reader);
            

}


}


}