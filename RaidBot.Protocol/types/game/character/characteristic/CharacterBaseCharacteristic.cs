


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class CharacterBaseCharacteristic
{

public const short Id = 4;
public virtual short TypeId
{
    get { return Id; }
}

public short @base;
        public short additionnal;
        public short objectsAndMountBonus;
        public short alignGiftBonus;
        public short contextModif;
        

public CharacterBaseCharacteristic()
{
}

public CharacterBaseCharacteristic(short @base, short additionnal, short objectsAndMountBonus, short alignGiftBonus, short contextModif)
        {
            this.@base = @base;
            this.additionnal = additionnal;
            this.objectsAndMountBonus = objectsAndMountBonus;
            this.alignGiftBonus = alignGiftBonus;
            this.contextModif = contextModif;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVarshort(@base);
            writer.WriteVarshort(additionnal);
            writer.WriteVarshort(objectsAndMountBonus);
            writer.WriteVarshort(alignGiftBonus);
            writer.WriteVarshort(contextModif);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

@base = reader.ReadVarshort();
            additionnal = reader.ReadVarshort();
            objectsAndMountBonus = reader.ReadVarshort();
            alignGiftBonus = reader.ReadVarshort();
            contextModif = reader.ReadVarshort();
            

}


}


}