


















// Generated on 06/26/2015 11:41:19
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MountSterilizedMessage : NetworkMessage
{

public const uint Id = 5977;
public override uint MessageId
{
    get { return Id; }
}

public int mountId;
        

public MountSterilizedMessage()
{
}

public MountSterilizedMessage(int mountId)
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