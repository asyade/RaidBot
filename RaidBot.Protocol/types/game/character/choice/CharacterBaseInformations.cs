


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class CharacterBaseInformations : CharacterMinimalPlusLookInformations
{

public const short Id = 45;
public override short TypeId
{
    get { return Id; }
}

public sbyte breed;
        public bool sex;
        

public CharacterBaseInformations()
{
}

public CharacterBaseInformations(uint id, byte level, string name, Types.EntityLook entityLook, sbyte breed, bool sex)
         : base(id, level, name, entityLook)
        {
            this.breed = breed;
            this.sex = sex;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
            

}


}


}