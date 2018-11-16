


















// Generated on 06/26/2015 11:41:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightModifyEffectsDurationMessage : AbstractGameActionMessage
{

public const uint Id = 6304;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public short delta;
        

public GameActionFightModifyEffectsDurationMessage()
{
}

public GameActionFightModifyEffectsDurationMessage(ushort actionId, int sourceId, int targetId, short delta)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.delta = delta;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteShort(delta);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            delta = reader.ReadShort();
            

}


}


}