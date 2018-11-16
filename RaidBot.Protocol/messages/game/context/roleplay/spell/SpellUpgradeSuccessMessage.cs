


















// Generated on 06/26/2015 11:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SpellUpgradeSuccessMessage : NetworkMessage
{

public const uint Id = 1201;
public override uint MessageId
{
    get { return Id; }
}

public int spellId;
        public sbyte spellLevel;
        

public SpellUpgradeSuccessMessage()
{
}

public SpellUpgradeSuccessMessage(int spellId, sbyte spellLevel)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(spellId);
            writer.WriteSByte(spellLevel);
            

}

public override void Deserialize(ICustomDataReader reader)
{

spellId = reader.ReadInt();
            spellLevel = reader.ReadSByte();
            if (spellLevel < 1 || spellLevel > 6)
                throw new Exception("Forbidden value on spellLevel = " + spellLevel + ", it doesn't respect the following condition : spellLevel < 1 || spellLevel > 6");
            

}


}


}