


















// Generated on 06/26/2015 11:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class KamasUpdateMessage : NetworkMessage
{

public const uint Id = 5537;
public override uint MessageId
{
    get { return Id; }
}

public int kamasTotal;
        

public KamasUpdateMessage()
{
}

public KamasUpdateMessage(int kamasTotal)
        {
            this.kamasTotal = kamasTotal;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVarint(kamasTotal);
            

}

public override void Deserialize(ICustomDataReader reader)
{

kamasTotal = reader.ReadVarint();
            

}


}


}