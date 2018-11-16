


















// Generated on 06/26/2015 11:41:21
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MapRunningFightListRequestMessage : NetworkMessage
{

public const uint Id = 5742;
public override uint MessageId
{
    get { return Id; }
}



public MapRunningFightListRequestMessage()
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