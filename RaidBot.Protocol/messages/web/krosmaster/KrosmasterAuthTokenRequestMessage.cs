


















// Generated on 06/26/2015 11:41:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class KrosmasterAuthTokenRequestMessage : NetworkMessage
{

public const uint Id = 6346;
public override uint MessageId
{
    get { return Id; }
}



public KrosmasterAuthTokenRequestMessage()
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