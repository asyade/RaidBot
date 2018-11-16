


















// Generated on 06/26/2015 11:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GoldAddedMessage : NetworkMessage
{

public const uint Id = 6030;
public override uint MessageId
{
    get { return Id; }
}

public Types.GoldItem gold;
        

public GoldAddedMessage()
{
}

public GoldAddedMessage(Types.GoldItem gold)
        {
            this.gold = gold;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

gold.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

gold = new Types.GoldItem();
            gold.Deserialize(reader);
            

}


}


}