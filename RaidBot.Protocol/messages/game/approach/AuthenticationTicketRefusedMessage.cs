


















// Generated on 06/26/2015 11:41:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AuthenticationTicketRefusedMessage : NetworkMessage
{

public const uint Id = 112;
public override uint MessageId
{
    get { return Id; }
}



public AuthenticationTicketRefusedMessage()
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