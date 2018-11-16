


















// Generated on 06/26/2015 11:41:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightSpellCooldownVariationMessage : AbstractGameActionMessage
{

public const uint Id = 6219;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public ushort spellId;
        public short value;
        

public GameActionFightSpellCooldownVariationMessage()
{
}

public GameActionFightSpellCooldownVariationMessage(ushort actionId, int sourceId, int targetId, ushort spellId, short value)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.spellId = spellId;
            this.value = value;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteVaruhshort(spellId);
            writer.WriteVarshort(value);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            spellId = reader.ReadVaruhshort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            value = reader.ReadVarshort();
            

}


}


}