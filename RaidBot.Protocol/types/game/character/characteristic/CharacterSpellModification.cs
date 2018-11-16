


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class CharacterSpellModification
{

public const short Id = 215;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte modificationType;
        public ushort spellId;
        public Types.CharacterBaseCharacteristic value;
        

public CharacterSpellModification()
{
}

public CharacterSpellModification(sbyte modificationType, ushort spellId, Types.CharacterBaseCharacteristic value)
        {
            this.modificationType = modificationType;
            this.spellId = spellId;
            this.value = value;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(modificationType);
            writer.WriteVaruhshort(spellId);
            value.Serialize(writer);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

modificationType = reader.ReadSByte();
            if (modificationType < 0)
                throw new Exception("Forbidden value on modificationType = " + modificationType + ", it doesn't respect the following condition : modificationType < 0");
            spellId = reader.ReadVaruhshort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            value = new Types.CharacterBaseCharacteristic();
            value.Deserialize(reader);
            

}


}


}