


















// Generated on 06/26/2015 11:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class HouseGuildRightsMessage : NetworkMessage
{

public const uint Id = 5703;
public override uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public Types.GuildInformations guildInfo;
        public uint rights;
        

public HouseGuildRightsMessage()
{
}

public HouseGuildRightsMessage(uint houseId, Types.GuildInformations guildInfo, uint rights)
        {
            this.houseId = houseId;
            this.guildInfo = guildInfo;
            this.rights = rights;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(houseId);
            guildInfo.Serialize(writer);
            writer.WriteVaruhint(rights);
            

}

public override void Deserialize(ICustomDataReader reader)
{

houseId = reader.ReadVaruhint();
            if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            rights = reader.ReadVaruhint();
            if (rights < 0)
                throw new Exception("Forbidden value on rights = " + rights + ", it doesn't respect the following condition : rights < 0");
            

}


}


}