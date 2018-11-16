


















// Generated on 06/26/2015 11:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SpellUpgradeRequestMessage : NetworkMessage
{

public const uint Id = 5608;
public override uint MessageId
{
    get { return Id; }
}

public ushort spellId;
        public sbyte spellLevel;
        

public SpellUpgradeRequestMessage()
{
}

public SpellUpgradeRequestMessage(ushort spellId, sbyte spellLevel)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(spellId);
            writer.WriteSByte(spellLevel);
            

}

public override void Deserialize(ICustomDataReader reader)
{

spellId = reader.ReadVaruhshort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            spellLevel = reader.ReadSByte();
            if (spellLevel < 1 || spellLevel > 6)
                throw new Exception("Forbidden value on spellLevel = " + spellLevel + ", it doesn't respect the following condition : spellLevel < 1 || spellLevel > 6");
            

}


}


}