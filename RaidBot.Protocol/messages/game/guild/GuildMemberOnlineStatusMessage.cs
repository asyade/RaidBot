


















// Generated on 06/26/2015 11:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildMemberOnlineStatusMessage : NetworkMessage
{

public const uint Id = 6061;
public override uint MessageId
{
    get { return Id; }
}

public uint memberId;
        public bool online;
        

public GuildMemberOnlineStatusMessage()
{
}

public GuildMemberOnlineStatusMessage(uint memberId, bool online)
        {
            this.memberId = memberId;
            this.online = online;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(memberId);
            writer.WriteBoolean(online);
            

}

public override void Deserialize(ICustomDataReader reader)
{

memberId = reader.ReadVaruhint();
            if (memberId < 0)
                throw new Exception("Forbidden value on memberId = " + memberId + ", it doesn't respect the following condition : memberId < 0");
            online = reader.ReadBoolean();
            

}


}


}