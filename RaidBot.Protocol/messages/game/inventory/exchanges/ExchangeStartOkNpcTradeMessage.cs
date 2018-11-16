


















// Generated on 06/26/2015 11:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeStartOkNpcTradeMessage : NetworkMessage
{

public const uint Id = 5785;
public override uint MessageId
{
    get { return Id; }
}

public int npcId;
        

public ExchangeStartOkNpcTradeMessage()
{
}

public ExchangeStartOkNpcTradeMessage(int npcId)
        {
            this.npcId = npcId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(npcId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

npcId = reader.ReadInt();
            

}


}


}