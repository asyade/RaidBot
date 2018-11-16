


















// Generated on 06/26/2015 11:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeBidHousePriceMessage : NetworkMessage
{

public const uint Id = 5805;
public override uint MessageId
{
    get { return Id; }
}

public ushort genId;
        

public ExchangeBidHousePriceMessage()
{
}

public ExchangeBidHousePriceMessage(ushort genId)
        {
            this.genId = genId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(genId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

genId = reader.ReadVaruhshort();
            if (genId < 0)
                throw new Exception("Forbidden value on genId = " + genId + ", it doesn't respect the following condition : genId < 0");
            

}


}


}