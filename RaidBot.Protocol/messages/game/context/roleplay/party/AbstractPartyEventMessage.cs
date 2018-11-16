


















// Generated on 06/26/2015 11:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AbstractPartyEventMessage : AbstractPartyMessage
{

public const uint Id = 6273;
public override uint MessageId
{
    get { return Id; }
}



public AbstractPartyEventMessage()
{
}

public AbstractPartyEventMessage(uint partyId)
         : base(partyId)
        {
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            

}


}


}