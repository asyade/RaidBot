


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class CharacterToRemodelInformations : CharacterRemodelingInformation
{

public const short Id = 477;
public override short TypeId
{
    get { return Id; }
}

public sbyte possibleChangeMask;
        public sbyte mandatoryChangeMask;
        

public CharacterToRemodelInformations()
{
}

public CharacterToRemodelInformations(uint id, string name, sbyte breed, bool sex, ushort cosmeticId, int[] colors, sbyte possibleChangeMask, sbyte mandatoryChangeMask)
         : base(id, name, breed, sex, cosmeticId, colors)
        {
            this.possibleChangeMask = possibleChangeMask;
            this.mandatoryChangeMask = mandatoryChangeMask;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(possibleChangeMask);
            writer.WriteSByte(mandatoryChangeMask);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            possibleChangeMask = reader.ReadSByte();
            if (possibleChangeMask < 0)
                throw new Exception("Forbidden value on possibleChangeMask = " + possibleChangeMask + ", it doesn't respect the following condition : possibleChangeMask < 0");
            mandatoryChangeMask = reader.ReadSByte();
            if (mandatoryChangeMask < 0)
                throw new Exception("Forbidden value on mandatoryChangeMask = " + mandatoryChangeMask + ", it doesn't respect the following condition : mandatoryChangeMask < 0");
            

}


}


}