


















// Generated on 06/26/2015 11:42:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameFightAIInformations : GameFightFighterInformations
{

public const short Id = 151;
public override short TypeId
{
    get { return Id; }
}



public GameFightAIInformations()
{
}

public GameFightAIInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, Types.GameFightMinimalStats stats, ushort[] previousPositions)
         : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions)
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