


















// Generated on 06/26/2015 11:41:19
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MountSetMessage : NetworkMessage
{

public const uint Id = 5968;
public override uint MessageId
{
    get { return Id; }
}

public Types.MountClientData mountData;
        

public MountSetMessage()
{
}

public MountSetMessage(Types.MountClientData mountData)
        {
            this.mountData = mountData;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

mountData.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

mountData = new Types.MountClientData();
            mountData.Deserialize(reader);
            

}


}


}