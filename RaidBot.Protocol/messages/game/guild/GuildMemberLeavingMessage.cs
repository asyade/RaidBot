


















// Generated on 06/26/2015 11:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildMemberLeavingMessage : NetworkMessage
{

public const uint Id = 5923;
public override uint MessageId
{
    get { return Id; }
}

public bool kicked;
        public int memberId;
        

public GuildMemberLeavingMessage()
{
}

public GuildMemberLeavingMessage(bool kicked, int memberId)
        {
            this.kicked = kicked;
            this.memberId = memberId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(kicked);
            writer.WriteInt(memberId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

kicked = reader.ReadBoolean();
            memberId = reader.ReadInt();
            

}


}


}