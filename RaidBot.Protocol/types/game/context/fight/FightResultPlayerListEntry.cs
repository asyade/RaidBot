


















// Generated on 06/26/2015 11:42:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightResultPlayerListEntry : FightResultFighterListEntry
{

public const short Id = 24;
public override short TypeId
{
    get { return Id; }
}

public byte level;
        public Types.FightResultAdditionalData[] additional;
        

public FightResultPlayerListEntry()
{
}

public FightResultPlayerListEntry(ushort outcome, sbyte wave, Types.FightLoot rewards, int id, bool alive, byte level, Types.FightResultAdditionalData[] additional)
         : base(outcome, wave, rewards, id, alive)
        {
            this.level = level;
            this.additional = additional;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteByte(level);
            writer.WriteUShort((ushort)additional.Length);
            foreach (var entry in additional)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            level = reader.ReadByte();
            if (level < 1 || level > 200)
                throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 1 || level > 200");
            var limit = reader.ReadUShort();
            additional = new Types.FightResultAdditionalData[limit];
            for (int i = 0; i < limit; i++)
            {
                 additional[i] = Types.ProtocolTypeManager.GetInstance<Types.FightResultAdditionalData>(reader.ReadShort());
                 additional[i].Deserialize(reader);
            }
            

}


}


}