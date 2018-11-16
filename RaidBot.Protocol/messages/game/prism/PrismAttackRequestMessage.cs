


















// Generated on 06/26/2015 11:41:54
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismAttackRequestMessage : NetworkMessage
{

public const uint Id = 6042;
public override uint MessageId
{
    get { return Id; }
}



public PrismAttackRequestMessage()
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