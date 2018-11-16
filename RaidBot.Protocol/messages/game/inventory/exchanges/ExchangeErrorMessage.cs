


















// Generated on 06/26/2015 11:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeErrorMessage : NetworkMessage
{

public const uint Id = 5513;
public override uint MessageId
{
    get { return Id; }
}

public sbyte errorType;
        

public ExchangeErrorMessage()
{
}

public ExchangeErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(errorType);
            

}

public override void Deserialize(ICustomDataReader reader)
{

errorType = reader.ReadSByte();
            

}


}


}