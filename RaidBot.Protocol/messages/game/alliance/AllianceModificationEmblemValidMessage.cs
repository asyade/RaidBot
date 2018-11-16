


















// Generated on 06/26/2015 11:41:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceModificationEmblemValidMessage : NetworkMessage
{

public const uint Id = 6447;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildEmblem Alliancemblem;
        

public AllianceModificationEmblemValidMessage()
{
}

public AllianceModificationEmblemValidMessage(Types.GuildEmblem Alliancemblem)
        {
            this.Alliancemblem = Alliancemblem;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

Alliancemblem.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

Alliancemblem = new Types.GuildEmblem();
            Alliancemblem.Deserialize(reader);
            

}


}


}