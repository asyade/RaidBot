


















// Generated on 06/26/2015 11:41:13
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameCautiousMapMovementRequestMessage : GameMapMovementRequestMessage
{

public const uint Id = 6496;
public override uint MessageId
{
    get { return Id; }
}



public GameCautiousMapMovementRequestMessage()
{
}

public GameCautiousMapMovementRequestMessage(short[] keyMovements, int mapId)
         : base(keyMovements, mapId)
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