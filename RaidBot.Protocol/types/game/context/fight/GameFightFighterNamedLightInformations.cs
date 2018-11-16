


















// Generated on 06/26/2015 11:42:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameFightFighterNamedLightInformations : GameFightFighterLightInformations
{

public const short Id = 456;
public override short TypeId
{
    get { return Id; }
}

public string name;
        

public GameFightFighterNamedLightInformations()
{
}

public GameFightFighterNamedLightInformations(bool sex, bool alive, int id, sbyte wave, ushort level, sbyte breed, string name)
         : base(sex, alive, id, wave, level, breed)
        {
            this.name = name;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            

}


}


}