


















// Generated on 06/26/2015 11:41:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightSpellCastMessage : AbstractGameActionFightTargetedAbilityMessage
{

public const uint Id = 1010;
public override uint MessageId
{
    get { return Id; }
}

public ushort spellId;
        public sbyte spellLevel;
        public short[] portalsIds;
        

public GameActionFightSpellCastMessage()
{
}

public GameActionFightSpellCastMessage(ushort actionId, int sourceId, int targetId, short destinationCellId, sbyte critical, bool silentCast, ushort spellId, sbyte spellLevel, short[] portalsIds)
         : base(actionId, sourceId, targetId, destinationCellId, critical, silentCast)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
            this.portalsIds = portalsIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(spellId);
            writer.WriteSByte(spellLevel);
            writer.WriteUShort((ushort)portalsIds.Length);
            foreach (var entry in portalsIds)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            spellId = reader.ReadVaruhshort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            spellLevel = reader.ReadSByte();
            if (spellLevel < 1 || spellLevel > 6)
                throw new Exception("Forbidden value on spellLevel = " + spellLevel + ", it doesn't respect the following condition : spellLevel < 1 || spellLevel > 6");
            var limit = reader.ReadUShort();
            portalsIds = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 portalsIds[i] = reader.ReadShort();
            }
            

}


}


}