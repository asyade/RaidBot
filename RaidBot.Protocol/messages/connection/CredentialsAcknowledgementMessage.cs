


















// Generated on 06/26/2015 11:40:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CredentialsAcknowledgementMessage : NetworkMessage
{

public const uint Id = 6314;
public override uint MessageId
{
    get { return Id; }
}



public CredentialsAcknowledgementMessage()
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