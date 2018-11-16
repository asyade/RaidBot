


















// Generated on 06/26/2015 11:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeRequestedTradeMessage : ExchangeRequestedMessage
{

public const uint Id = 5523;
public override uint MessageId
{
    get { return Id; }
}

public uint source;
        public uint target;
        

public ExchangeRequestedTradeMessage()
{
}

public ExchangeRequestedTradeMessage(sbyte exchangeType, uint source, uint target)
         : base(exchangeType)
        {
            this.source = source;
            this.target = target;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(source);
            writer.WriteVaruhint(target);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            source = reader.ReadVaruhint();
            if (source < 0)
                throw new Exception("Forbidden value on source = " + source + ", it doesn't respect the following condition : source < 0");
            target = reader.ReadVaruhint();
            if (target < 0)
                throw new Exception("Forbidden value on target = " + target + ", it doesn't respect the following condition : target < 0");
            

}


}


}