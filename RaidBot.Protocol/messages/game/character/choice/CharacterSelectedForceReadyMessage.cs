


















// Generated on 06/26/2015 11:41:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CharacterSelectedForceReadyMessage : NetworkMessage
{

public const uint Id = 6072;
public override uint MessageId
{
    get { return Id; }
}



public CharacterSelectedForceReadyMessage()
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