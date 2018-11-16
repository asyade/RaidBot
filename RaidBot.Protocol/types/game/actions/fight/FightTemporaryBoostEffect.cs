


















// Generated on 06/26/2015 11:42:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightTemporaryBoostEffect : AbstractFightDispellableEffect
{

public const short Id = 209;
public override short TypeId
{
    get { return Id; }
}

public short delta;
        

public FightTemporaryBoostEffect()
{
}

public FightTemporaryBoostEffect(uint uid, int targetId, short turnDuration, sbyte dispelable, ushort spellId, uint effectId, uint parentBoostUid, short delta)
         : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid)
        {
            this.delta = delta;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(delta);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            delta = reader.ReadShort();
            

}


}


}