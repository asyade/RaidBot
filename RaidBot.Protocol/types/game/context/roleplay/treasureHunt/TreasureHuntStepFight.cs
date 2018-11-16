


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class TreasureHuntStepFight : TreasureHuntStep
{

public const short Id = 462;
public override short TypeId
{
    get { return Id; }
}



public TreasureHuntStepFight()
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