


















// Generated on 06/26/2015 11:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeReplayCountModifiedMessage : NetworkMessage
{

public const uint Id = 6023;
public override uint MessageId
{
    get { return Id; }
}

public int count;
        

public ExchangeReplayCountModifiedMessage()
{
}

public ExchangeReplayCountModifiedMessage(int count)
        {
            this.count = count;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVarint(count);
            

}

public override void Deserialize(ICustomDataReader reader)
{

count = reader.ReadVarint();
            

}


}


}