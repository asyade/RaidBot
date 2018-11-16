


















// Generated on 06/26/2015 11:41:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightDispellSpellMessage : GameActionFightDispellMessage
{

public const uint Id = 6176;
public override uint MessageId
{
    get { return Id; }
}

public ushort spellId;
        

public GameActionFightDispellSpellMessage()
{
}

public GameActionFightDispellSpellMessage(ushort actionId, int sourceId, int targetId, ushort spellId)
         : base(actionId, sourceId, targetId)
        {
            this.spellId = spellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(spellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            spellId = reader.ReadVaruhshort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            

}


}


}