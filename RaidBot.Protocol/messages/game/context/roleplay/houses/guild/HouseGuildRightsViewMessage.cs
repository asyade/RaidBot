


















// Generated on 06/26/2015 11:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class HouseGuildRightsViewMessage : NetworkMessage
{

public const uint Id = 5700;
public override uint MessageId
{
    get { return Id; }
}



public HouseGuildRightsViewMessage()
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