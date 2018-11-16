


















// Generated on 06/26/2015 11:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildInvitedMessage : NetworkMessage
{

public const uint Id = 5552;
public override uint MessageId
{
    get { return Id; }
}

public uint recruterId;
        public string recruterName;
        public Types.BasicGuildInformations guildInfo;
        

public GuildInvitedMessage()
{
}

public GuildInvitedMessage(uint recruterId, string recruterName, Types.BasicGuildInformations guildInfo)
        {
            this.recruterId = recruterId;
            this.recruterName = recruterName;
            this.guildInfo = guildInfo;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(recruterId);
            writer.WriteUTF(recruterName);
            guildInfo.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

recruterId = reader.ReadVaruhint();
            if (recruterId < 0)
                throw new Exception("Forbidden value on recruterId = " + recruterId + ", it doesn't respect the following condition : recruterId < 0");
            recruterName = reader.ReadUTF();
            guildInfo = new Types.BasicGuildInformations();
            guildInfo.Deserialize(reader);
            

}


}


}