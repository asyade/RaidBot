


















// Generated on 06/26/2015 11:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlaySpellAnimMessage : NetworkMessage
{

public const uint Id = 6114;
public override uint MessageId
{
    get { return Id; }
}

public int casterId;
        public ushort targetCellId;
        public ushort spellId;
        public sbyte spellLevel;
        

public GameRolePlaySpellAnimMessage()
{
}

public GameRolePlaySpellAnimMessage(int casterId, ushort targetCellId, ushort spellId, sbyte spellLevel)
        {
            this.casterId = casterId;
            this.targetCellId = targetCellId;
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(casterId);
            writer.WriteVaruhshort(targetCellId);
            writer.WriteVaruhshort(spellId);
            writer.WriteSByte(spellLevel);
            

}

public override void Deserialize(ICustomDataReader reader)
{

casterId = reader.ReadInt();
            targetCellId = reader.ReadVaruhshort();
            if (targetCellId < 0 || targetCellId > 559)
                throw new Exception("Forbidden value on targetCellId = " + targetCellId + ", it doesn't respect the following condition : targetCellId < 0 || targetCellId > 559");
            spellId = reader.ReadVaruhshort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            spellLevel = reader.ReadSByte();
            if (spellLevel < 1 || spellLevel > 6)
                throw new Exception("Forbidden value on spellLevel = " + spellLevel + ", it doesn't respect the following condition : spellLevel < 1 || spellLevel > 6");
            

}


}


}