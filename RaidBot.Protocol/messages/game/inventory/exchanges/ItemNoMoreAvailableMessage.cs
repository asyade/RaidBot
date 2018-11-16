


















// Generated on 06/26/2015 11:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ItemNoMoreAvailableMessage : NetworkMessage
{

public const uint Id = 5769;
public override uint MessageId
{
    get { return Id; }
}



public ItemNoMoreAvailableMessage()
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