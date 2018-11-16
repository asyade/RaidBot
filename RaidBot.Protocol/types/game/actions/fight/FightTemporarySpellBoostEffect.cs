


















// Generated on 06/26/2015 11:42:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightTemporarySpellBoostEffect : FightTemporaryBoostEffect
{

public const short Id = 207;
public override short TypeId
{
    get { return Id; }
}

public ushort boostedSpellId;
        

public FightTemporarySpellBoostEffect()
{
}

public FightTemporarySpellBoostEffect(uint uid, int targetId, short turnDuration, sbyte dispelable, ushort spellId, uint effectId, uint parentBoostUid, short delta, ushort boostedSpellId)
         : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid, delta)
        {
            this.boostedSpellId = boostedSpellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(boostedSpellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            boostedSpellId = reader.ReadVaruhshort();
            if (boostedSpellId < 0)
                throw new Exception("Forbidden value on boostedSpellId = " + boostedSpellId + ", it doesn't respect the following condition : boostedSpellId < 0");
            

}


}


}