


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class KrosmasterInventoryRequestMessage : NetworkMessage
{

public const uint Id = 6344;
public override uint MessageId
{
    get { return Id; }
}



public KrosmasterInventoryRequestMessage()
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