


















// Generated on 06/26/2015 11:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeObjectMoveKamaMessage : NetworkMessage
{

public const uint Id = 5520;
public override uint MessageId
{
    get { return Id; }
}

public int quantity;
        

public ExchangeObjectMoveKamaMessage()
{
}

public ExchangeObjectMoveKamaMessage(int quantity)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVarint(quantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

quantity = reader.ReadVarint();
            

}


}


}