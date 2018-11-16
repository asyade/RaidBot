


















// Generated on 06/26/2015 11:41:13
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameContextDestroyMessage : NetworkMessage
{

public const uint Id = 201;
public override uint MessageId
{
    get { return Id; }
}



public GameContextDestroyMessage()
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