


















// Generated on 06/26/2015 11:41:19
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MountReleasedMessage : NetworkMessage
{

public const uint Id = 6308;
public override uint MessageId
{
    get { return Id; }
}

public int mountId;
        

public MountReleasedMessage()
{
}

public MountReleasedMessage(int mountId)
        {
            this.mountId = mountId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVarint(mountId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

mountId = reader.ReadVarint();
            

}


}


}