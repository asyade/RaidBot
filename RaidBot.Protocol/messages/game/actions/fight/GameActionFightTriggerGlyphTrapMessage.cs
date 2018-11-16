


















// Generated on 06/26/2015 11:41:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightTriggerGlyphTrapMessage : AbstractGameActionMessage
{

public const uint Id = 5741;
public override uint MessageId
{
    get { return Id; }
}

public short markId;
        public int triggeringCharacterId;
        public ushort triggeredSpellId;
        

public GameActionFightTriggerGlyphTrapMessage()
{
}

public GameActionFightTriggerGlyphTrapMessage(ushort actionId, int sourceId, short markId, int triggeringCharacterId, ushort triggeredSpellId)
         : base(actionId, sourceId)
        {
            this.markId = markId;
            this.triggeringCharacterId = triggeringCharacterId;
            this.triggeredSpellId = triggeredSpellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(markId);
            writer.WriteInt(triggeringCharacterId);
            writer.WriteVaruhshort(triggeredSpellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            markId = reader.ReadShort();
            triggeringCharacterId = reader.ReadInt();
            triggeredSpellId = reader.ReadVaruhshort();
            if (triggeredSpellId < 0)
                throw new Exception("Forbidden value on triggeredSpellId = " + triggeredSpellId + ", it doesn't respect the following condition : triggeredSpellId < 0");
            

}


}


}