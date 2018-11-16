


















// Generated on 06/26/2015 11:42:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AbstractFightDispellableEffect
{

public const short Id = 206;
public virtual short TypeId
{
    get { return Id; }
}

public uint uid;
        public int targetId;
        public short turnDuration;
        public sbyte dispelable;
        public ushort spellId;
        public uint effectId;
        public uint parentBoostUid;
        

public AbstractFightDispellableEffect()
{
}

public AbstractFightDispellableEffect(uint uid, int targetId, short turnDuration, sbyte dispelable, ushort spellId, uint effectId, uint parentBoostUid)
        {
            this.uid = uid;
            this.targetId = targetId;
            this.turnDuration = turnDuration;
            this.dispelable = dispelable;
            this.spellId = spellId;
            this.effectId = effectId;
            this.parentBoostUid = parentBoostUid;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(uid);
            writer.WriteInt(targetId);
            writer.WriteShort(turnDuration);
            writer.WriteSByte(dispelable);
            writer.WriteVaruhshort(spellId);
            writer.WriteVaruhint(effectId);
            writer.WriteVaruhint(parentBoostUid);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

uid = reader.ReadVaruhint();
            if (uid < 0)
                throw new Exception("Forbidden value on uid = " + uid + ", it doesn't respect the following condition : uid < 0");
            targetId = reader.ReadInt();
            turnDuration = reader.ReadShort();
            dispelable = reader.ReadSByte();
            if (dispelable < 0)
                throw new Exception("Forbidden value on dispelable = " + dispelable + ", it doesn't respect the following condition : dispelable < 0");
            spellId = reader.ReadVaruhshort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            effectId = reader.ReadVaruhint();
            if (effectId < 0)
                throw new Exception("Forbidden value on effectId = " + effectId + ", it doesn't respect the following condition : effectId < 0");
            parentBoostUid = reader.ReadVaruhint();
            if (parentBoostUid < 0)
                throw new Exception("Forbidden value on parentBoostUid = " + parentBoostUid + ", it doesn't respect the following condition : parentBoostUid < 0");
            

}


}


}