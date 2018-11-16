


















// Generated on 06/26/2015 11:41:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceGuildLeavingMessage : NetworkMessage
{

public const uint Id = 6399;
public override uint MessageId
{
    get { return Id; }
}

public bool kicked;
        public uint guildId;
        

public AllianceGuildLeavingMessage()
{
}

public AllianceGuildLeavingMessage(bool kicked, uint guildId)
        {
            this.kicked = kicked;
            this.guildId = guildId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(kicked);
            writer.WriteVaruhint(guildId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

kicked = reader.ReadBoolean();
            guildId = reader.ReadVaruhint();
            if (guildId < 0)
                throw new Exception("Forbidden value on guildId = " + guildId + ", it doesn't respect the following condition : guildId < 0");
            

}


}


}