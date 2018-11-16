


















// Generated on 06/26/2015 11:41:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightSpellImmunityMessage : AbstractGameActionMessage
{

public const uint Id = 6221;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public ushort spellId;
        

public GameActionFightSpellImmunityMessage()
{
}

public GameActionFightSpellImmunityMessage(ushort actionId, int sourceId, int targetId, ushort spellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.spellId = spellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteVaruhshort(spellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            spellId = reader.ReadVaruhshort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            

}


}


}