


















// Generated on 06/26/2015 11:41:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightReflectSpellMessage : AbstractGameActionMessage
{

public const uint Id = 5531;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        

public GameActionFightReflectSpellMessage()
{
}

public GameActionFightReflectSpellMessage(ushort actionId, int sourceId, int targetId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            

}


}


}