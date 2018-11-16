


















// Generated on 06/26/2015 11:42:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class CharacterMinimalGuildInformations : CharacterMinimalPlusLookInformations
{

public const short Id = 445;
public override short TypeId
{
    get { return Id; }
}

public Types.BasicGuildInformations guild;
        

public CharacterMinimalGuildInformations()
{
}

public CharacterMinimalGuildInformations(uint id, byte level, string name, Types.EntityLook entityLook, Types.BasicGuildInformations guild)
         : base(id, level, name, entityLook)
        {
            this.guild = guild;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            guild.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
            

}


}


}