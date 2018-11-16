


















// Generated on 06/26/2015 11:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SpellItemBoostMessage : NetworkMessage
{

public const uint Id = 6011;
public override uint MessageId
{
    get { return Id; }
}

public uint statId;
        public ushort spellId;
        public short value;
        

public SpellItemBoostMessage()
{
}

public SpellItemBoostMessage(uint statId, ushort spellId, short value)
        {
            this.statId = statId;
            this.spellId = spellId;
            this.value = value;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(statId);
            writer.WriteVaruhshort(spellId);
            writer.WriteVarshort(value);
            

}

public override void Deserialize(ICustomDataReader reader)
{

statId = reader.ReadVaruhint();
            if (statId < 0)
                throw new Exception("Forbidden value on statId = " + statId + ", it doesn't respect the following condition : statId < 0");
            spellId = reader.ReadVaruhshort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            value = reader.ReadVarshort();
            

}


}


}