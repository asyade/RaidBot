


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SpellListMessage : NetworkMessage
{

public const uint Id = 1200;
public override uint MessageId
{
    get { return Id; }
}

public bool spellPrevisualization;
        public Types.SpellItem[] spells;
        

public SpellListMessage()
{
}

public SpellListMessage(bool spellPrevisualization, Types.SpellItem[] spells)
        {
            this.spellPrevisualization = spellPrevisualization;
            this.spells = spells;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(spellPrevisualization);
            writer.WriteUShort((ushort)spells.Length);
            foreach (var entry in spells)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

spellPrevisualization = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            spells = new Types.SpellItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 spells[i] = new Types.SpellItem();
                 spells[i].Deserialize(reader);
            }
            

}


}


}