


















// Generated on 06/26/2015 11:41:13
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameCautiousMapMovementMessage : GameMapMovementMessage
{

public const uint Id = 6497;
public override uint MessageId
{
    get { return Id; }
}



public GameCautiousMapMovementMessage()
{
}

public GameCautiousMapMovementMessage(short[] keyMovements, int actorId)
         : base(keyMovements, actorId)
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