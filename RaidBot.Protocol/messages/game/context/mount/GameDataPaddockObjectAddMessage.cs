


















// Generated on 06/26/2015 11:41:18
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameDataPaddockObjectAddMessage : NetworkMessage
{

public const uint Id = 5990;
public override uint MessageId
{
    get { return Id; }
}

public Types.PaddockItem paddockItemDescription;
        

public GameDataPaddockObjectAddMessage()
{
}

public GameDataPaddockObjectAddMessage(Types.PaddockItem paddockItemDescription)
        {
            this.paddockItemDescription = paddockItemDescription;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

paddockItemDescription.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

paddockItemDescription = new Types.PaddockItem();
            paddockItemDescription.Deserialize(reader);
            

}


}


}