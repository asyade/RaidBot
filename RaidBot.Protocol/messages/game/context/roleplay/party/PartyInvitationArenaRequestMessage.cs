


















// Generated on 06/26/2015 11:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyInvitationArenaRequestMessage : PartyInvitationRequestMessage
{

public const uint Id = 6283;
public override uint MessageId
{
    get { return Id; }
}



public PartyInvitationArenaRequestMessage()
{
}

public PartyInvitationArenaRequestMessage(string name)
         : base(name)
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