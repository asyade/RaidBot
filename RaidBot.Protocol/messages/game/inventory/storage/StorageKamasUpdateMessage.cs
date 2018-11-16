


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class StorageKamasUpdateMessage : NetworkMessage
{

public const uint Id = 5645;
public override uint MessageId
{
    get { return Id; }
}

public int kamasTotal;
        

public StorageKamasUpdateMessage()
{
}

public StorageKamasUpdateMessage(int kamasTotal)
        {
            this.kamasTotal = kamasTotal;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(kamasTotal);
            

}

public override void Deserialize(ICustomDataReader reader)
{

kamasTotal = reader.ReadInt();
            

}


}


}