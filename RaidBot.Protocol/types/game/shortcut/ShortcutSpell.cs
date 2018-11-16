


















// Generated on 06/26/2015 11:42:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ShortcutSpell : Shortcut
{

public const short Id = 368;
public override short TypeId
{
    get { return Id; }
}

public ushort spellId;
        

public ShortcutSpell()
{
}

public ShortcutSpell(sbyte slot, ushort spellId)
         : base(slot)
        {
            this.spellId = spellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(spellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            spellId = reader.ReadVaruhshort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            

}


}


}