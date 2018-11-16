


















// Generated on 06/26/2015 11:41:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceChangeGuildRightsMessage : NetworkMessage
{

public const uint Id = 6426;
public override uint MessageId
{
    get { return Id; }
}

public uint guildId;
        public sbyte rights;
        

public AllianceChangeGuildRightsMessage()
{
}

public AllianceChangeGuildRightsMessage(uint guildId, sbyte rights)
        {
            this.guildId = guildId;
            this.rights = rights;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(guildId);
            writer.WriteSByte(rights);
            

}

public override void Deserialize(ICustomDataReader reader)
{

guildId = reader.ReadVaruhint();
            if (guildId < 0)
                throw new Exception("Forbidden value on guildId = " + guildId + ", it doesn't respect the following condition : guildId < 0");
            rights = reader.ReadSByte();
            if (rights < 0)
                throw new Exception("Forbidden value on rights = " + rights + ", it doesn't respect the following condition : rights < 0");
            

}


}


}