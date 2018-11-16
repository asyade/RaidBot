


















// Generated on 06/26/2015 11:41:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TitlesAndOrnamentsListRequestMessage : NetworkMessage
{

public const uint Id = 6363;
public override uint MessageId
{
    get { return Id; }
}



public TitlesAndOrnamentsListRequestMessage()
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