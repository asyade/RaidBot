


















// Generated on 06/26/2015 11:41:55
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismUseRequestMessage : NetworkMessage
{

public const uint Id = 6041;
public override uint MessageId
{
    get { return Id; }
}



public PrismUseRequestMessage()
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