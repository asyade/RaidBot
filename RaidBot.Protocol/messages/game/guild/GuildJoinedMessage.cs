


















// Generated on 06/26/2015 11:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildJoinedMessage : NetworkMessage
{

public const uint Id = 5564;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildInformations guildInfo;
        public uint memberRights;
        public bool enabled;
        

public GuildJoinedMessage()
{
}

public GuildJoinedMessage(Types.GuildInformations guildInfo, uint memberRights, bool enabled)
        {
            this.guildInfo = guildInfo;
            this.memberRights = memberRights;
            this.enabled = enabled;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

guildInfo.Serialize(writer);
            writer.WriteVaruhint(memberRights);
            writer.WriteBoolean(enabled);
            

}

public override void Deserialize(ICustomDataReader reader)
{

guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            memberRights = reader.ReadVaruhint();
            if (memberRights < 0)
                throw new Exception("Forbidden value on memberRights = " + memberRights + ", it doesn't respect the following condition : memberRights < 0");
            enabled = reader.ReadBoolean();
            

}


}


}