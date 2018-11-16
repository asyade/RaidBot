


















// Generated on 06/26/2015 11:41:18
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SlaveSwitchContextMessage : NetworkMessage
{

public const uint Id = 6214;
public override uint MessageId
{
    get { return Id; }
}

public int masterId;
        public int slaveId;
        public Types.SpellItem[] slaveSpells;
        public Types.CharacterCharacteristicsInformations slaveStats;
        public Types.Shortcut[] shortcuts;
        

public SlaveSwitchContextMessage()
{
}

public SlaveSwitchContextMessage(int masterId, int slaveId, Types.SpellItem[] slaveSpells, Types.CharacterCharacteristicsInformations slaveStats, Types.Shortcut[] shortcuts)
        {
            this.masterId = masterId;
            this.slaveId = slaveId;
            this.slaveSpells = slaveSpells;
            this.slaveStats = slaveStats;
            this.shortcuts = shortcuts;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(masterId);
            writer.WriteInt(slaveId);
            writer.WriteUShort((ushort)slaveSpells.Length);
            foreach (var entry in slaveSpells)
            {
                 entry.Serialize(writer);
            }
            slaveStats.Serialize(writer);
            writer.WriteUShort((ushort)shortcuts.Length);
            foreach (var entry in shortcuts)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

masterId = reader.ReadInt();
            slaveId = reader.ReadInt();
            var limit = reader.ReadUShort();
            slaveSpells = new Types.SpellItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 slaveSpells[i] = new Types.SpellItem();
                 slaveSpells[i].Deserialize(reader);
            }
            slaveStats = new Types.CharacterCharacteristicsInformations();
            slaveStats.Deserialize(reader);
            limit = reader.ReadUShort();
            shortcuts = new Types.Shortcut[limit];
            for (int i = 0; i < limit; i++)
            {
                 shortcuts[i] = Types.ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadShort());
                 shortcuts[i].Deserialize(reader);
            }
            

}


}


}