


















// Generated on 06/26/2015 11:40:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class NicknameAcceptedMessage : NetworkMessage
{

public const uint Id = 5641;
public override uint MessageId
{
    get { return Id; }
}



public NicknameAcceptedMessage()
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