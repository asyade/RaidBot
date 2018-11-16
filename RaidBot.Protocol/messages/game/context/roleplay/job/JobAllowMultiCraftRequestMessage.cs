


















// Generated on 06/26/2015 11:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class JobAllowMultiCraftRequestMessage : NetworkMessage
{

public const uint Id = 5748;
public override uint MessageId
{
    get { return Id; }
}

public bool enabled;
        

public JobAllowMultiCraftRequestMessage()
{
}

public JobAllowMultiCraftRequestMessage(bool enabled)
        {
            this.enabled = enabled;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(enabled);
            

}

public override void Deserialize(ICustomDataReader reader)
{

enabled = reader.ReadBoolean();
            

}


}


}