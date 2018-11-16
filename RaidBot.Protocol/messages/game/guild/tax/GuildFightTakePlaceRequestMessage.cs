


















// Generated on 06/26/2015 11:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildFightTakePlaceRequestMessage : GuildFightJoinRequestMessage
{

public const uint Id = 6235;
public override uint MessageId
{
    get { return Id; }
}

public int replacedCharacterId;
        

public GuildFightTakePlaceRequestMessage()
{
}

public GuildFightTakePlaceRequestMessage(int taxCollectorId, int replacedCharacterId)
         : base(taxCollectorId)
        {
            this.replacedCharacterId = replacedCharacterId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(replacedCharacterId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            replacedCharacterId = reader.ReadInt();
            

}


}


}