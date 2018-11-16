


















// Generated on 06/26/2015 11:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangePlayerRequestMessage : ExchangeRequestMessage
{

public const uint Id = 5773;
public override uint MessageId
{
    get { return Id; }
}

public uint target;
        

public ExchangePlayerRequestMessage()
{
}

public ExchangePlayerRequestMessage(sbyte exchangeType, uint target)
         : base(exchangeType)
        {
            this.target = target;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(target);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            target = reader.ReadVaruhint();
            if (target < 0)
                throw new Exception("Forbidden value on target = " + target + ", it doesn't respect the following condition : target < 0");
            

}


}


}