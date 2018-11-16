


















// Generated on 06/26/2015 11:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeCraftPaymentModifiedMessage : NetworkMessage
{

public const uint Id = 6578;
public override uint MessageId
{
    get { return Id; }
}

public uint goldSum;
        

public ExchangeCraftPaymentModifiedMessage()
{
}

public ExchangeCraftPaymentModifiedMessage(uint goldSum)
        {
            this.goldSum = goldSum;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(goldSum);
            

}

public override void Deserialize(ICustomDataReader reader)
{

goldSum = reader.ReadVaruhint();
            if (goldSum < 0)
                throw new Exception("Forbidden value on goldSum = " + goldSum + ", it doesn't respect the following condition : goldSum < 0");
            

}


}


}