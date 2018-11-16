


















// Generated on 06/26/2015 11:41:56
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SubscriptionZoneMessage : NetworkMessage
{

public const uint Id = 5573;
public override uint MessageId
{
    get { return Id; }
}

public bool active;
        

public SubscriptionZoneMessage()
{
}

public SubscriptionZoneMessage(bool active)
        {
            this.active = active;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(active);
            

}

public override void Deserialize(ICustomDataReader reader)
{

active = reader.ReadBoolean();
            

}


}


}