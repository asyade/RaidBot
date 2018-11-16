


















// Generated on 06/26/2015 11:41:19
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MountInformationInPaddockRequestMessage : NetworkMessage
{

public const uint Id = 5975;
public override uint MessageId
{
    get { return Id; }
}

public int mapRideId;
        

public MountInformationInPaddockRequestMessage()
{
}

public MountInformationInPaddockRequestMessage(int mapRideId)
        {
            this.mapRideId = mapRideId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVarint(mapRideId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

mapRideId = reader.ReadVarint();
            

}


}


}