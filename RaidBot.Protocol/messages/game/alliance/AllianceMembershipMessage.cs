


















// Generated on 06/26/2015 11:41:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceMembershipMessage : AllianceJoinedMessage
{

public const uint Id = 6390;
public override uint MessageId
{
    get { return Id; }
}



public AllianceMembershipMessage()
{
}

public AllianceMembershipMessage(Types.AllianceInformations allianceInfo, bool enabled)
         : base(allianceInfo, enabled)
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