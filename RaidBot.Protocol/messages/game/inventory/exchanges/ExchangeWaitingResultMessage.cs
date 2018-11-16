


















// Generated on 06/26/2015 11:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeWaitingResultMessage : NetworkMessage
{

public const uint Id = 5786;
public override uint MessageId
{
    get { return Id; }
}

public bool bwait;
        

public ExchangeWaitingResultMessage()
{
}

public ExchangeWaitingResultMessage(bool bwait)
        {
            this.bwait = bwait;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(bwait);
            

}

public override void Deserialize(ICustomDataReader reader)
{

bwait = reader.ReadBoolean();
            

}


}


}