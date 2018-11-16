


















// Generated on 06/26/2015 11:41:17
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightTurnReadyMessage : NetworkMessage
{

public const uint Id = 716;
public override uint MessageId
{
    get { return Id; }
}

public bool isReady;
        

public GameFightTurnReadyMessage()
{
}

public GameFightTurnReadyMessage(bool isReady)
        {
            this.isReady = isReady;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(isReady);
            

}

public override void Deserialize(ICustomDataReader reader)
{

isReady = reader.ReadBoolean();
            

}


}


}