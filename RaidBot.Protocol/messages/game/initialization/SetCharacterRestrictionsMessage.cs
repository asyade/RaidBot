


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SetCharacterRestrictionsMessage : NetworkMessage
{

public const uint Id = 170;
public override uint MessageId
{
    get { return Id; }
}

public int actorId;
        public Types.ActorRestrictionsInformations restrictions;
        

public SetCharacterRestrictionsMessage()
{
}

public SetCharacterRestrictionsMessage(int actorId, Types.ActorRestrictionsInformations restrictions)
        {
            this.actorId = actorId;
            this.restrictions = restrictions;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(actorId);
            restrictions.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

actorId = reader.ReadInt();
            restrictions = new Types.ActorRestrictionsInformations();
            restrictions.Deserialize(reader);
            

}


}


}