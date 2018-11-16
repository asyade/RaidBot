


















// Generated on 06/26/2015 11:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeStartedMessage : NetworkMessage
{

public const uint Id = 5512;
public override uint MessageId
{
    get { return Id; }
}

public sbyte exchangeType;
        

public ExchangeStartedMessage()
{
}

public ExchangeStartedMessage(sbyte exchangeType)
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