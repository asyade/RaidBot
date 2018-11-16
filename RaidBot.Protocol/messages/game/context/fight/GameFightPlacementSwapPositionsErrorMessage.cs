


















// Generated on 06/26/2015 11:41:16
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightPlacementSwapPositionsErrorMessage : NetworkMessage
{

public const uint Id = 6548;
public override uint MessageId
{
    get { return Id; }
}



public GameFightPlacementSwapPositionsErrorMessage()
{
}



public override void Serialize(ICustomDataWriter writer)
{



}

public override void Deserialize(ICustomDataReader reader)
{



}


}


}