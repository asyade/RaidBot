


















// Generated on 06/26/2015 11:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeRequestedMessage : NetworkMessage
{

public const uint Id = 5522;
public override uint MessageId
{
    get { return Id; }
}

public sbyte exchangeType;
        

public ExchangeRequestedMessage()
{
}

public ExchangeRequestedMessage(sbyte exchangeType)
        {
            this.exchangeType = exchangeType;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(exchangeType);
            

}

public override void Deserialize(ICustomDataReader reader)
{

exchangeType = reader.ReadSByte();
            

}


}


}