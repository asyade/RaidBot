


















// Generated on 06/26/2015 11:41:17
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightTurnReadyRequestMessage : NetworkMessage
{

public const uint Id = 715;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        

public GameFightTurnReadyRequestMessage()
{
}

public GameFightTurnReadyRequestMessage(int id)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(id);
            

}

public override void Deserialize(ICustomDataReader reader)
{

id = reader.ReadInt();
            

}


}


}