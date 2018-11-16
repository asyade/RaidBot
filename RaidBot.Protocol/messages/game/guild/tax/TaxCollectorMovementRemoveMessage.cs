


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TaxCollectorMovementRemoveMessage : NetworkMessage
{

public const uint Id = 5915;
public override uint MessageId
{
    get { return Id; }
}

public int collectorId;
        

public TaxCollectorMovementRemoveMessage()
{
}

public TaxCollectorMovementRemoveMessage(int collectorId)
        {
            this.collectorId = collectorId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(collectorId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

collectorId = reader.ReadInt();
            

}


}


}