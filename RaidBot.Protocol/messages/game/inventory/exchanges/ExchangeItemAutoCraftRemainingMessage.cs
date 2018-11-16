


















// Generated on 06/26/2015 11:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeItemAutoCraftRemainingMessage : NetworkMessage
{

public const uint Id = 6015;
public override uint MessageId
{
    get { return Id; }
}

public uint count;
        

public ExchangeItemAutoCraftRemainingMessage()
{
}

public ExchangeItemAutoCraftRemainingMessage(uint count)
        {
            this.count = count;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(count);
            

}

public override void Deserialize(ICustomDataReader reader)
{

count = reader.ReadVaruhint();
            if (count < 0)
                throw new Exception("Forbidden value on count = " + count + ", it doesn't respect the following condition : count < 0");
            

}


}


}