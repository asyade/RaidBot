


















// Generated on 06/26/2015 11:42:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class CharacterMinimalPlusLookInformations : CharacterMinimalInformations
{

public const short Id = 163;
public override short TypeId
{
    get { return Id; }
}

public Types.EntityLook entityLook;
        

public CharacterMinimalPlusLookInformations()
{
}

public CharacterMinimalPlusLookInformations(uint id, byte level, string name, Types.EntityLook entityLook)
         : base(id, level, name)
        {
            this.entityLook = entityLook;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            entityLook.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
            

}


}


}