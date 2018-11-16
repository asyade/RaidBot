


















// Generated on 06/26/2015 11:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class LockableStateUpdateAbstractMessage : NetworkMessage
{

public const uint Id = 5671;
public override uint MessageId
{
    get { return Id; }
}

public bool locked;
        

public LockableStateUpdateAbstractMessage()
{
}

public LockableStateUpdateAbstractMessage(bool locked)
        {
            this.locked = locked;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(locked);
            

}

public override void Deserialize(ICustomDataReader reader)
{

locked = reader.ReadBoolean();
            

}


}


}