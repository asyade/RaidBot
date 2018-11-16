


















// Generated on 06/26/2015 11:42:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameRolePlayActorInformations : GameContextActorInformations
{

public const short Id = 141;
public override short TypeId
{
    get { return Id; }
}



public GameRolePlayActorInformations()
{
}

public GameRolePlayActorInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition)
         : base(contextualId, look, disposition)
        {
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            

}


}


}