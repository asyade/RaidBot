


















// Generated on 06/26/2015 11:42:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightTriggeredEffect : AbstractFightDispellableEffect
{

public const short Id = 210;
public override short TypeId
{
    get { return Id; }
}

public int arg1;
        public int arg2;
        public int arg3;
        public short delay;
        

public FightTriggeredEffect()
{
}

public FightTriggeredEffect(uint uid, int targetId, short turnDuration, sbyte dispelable, ushort spellId, uint effectId, uint parentBoostUid, int arg1, int arg2, int arg3, short delay)
         : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid)
        {
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.delay = delay;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(arg1);
            writer.WriteInt(arg2);
            writer.WriteInt(arg3);
            writer.WriteShort(delay);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            arg1 = reader.ReadInt();
            arg2 = reader.ReadInt();
            arg3 = reader.ReadInt();
            delay = reader.ReadShort();
            

}


}


}