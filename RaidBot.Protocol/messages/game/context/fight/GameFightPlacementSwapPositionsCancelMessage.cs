


















// Generated on 06/26/2015 11:41:16
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightPlacementSwapPositionsCancelMessage : NetworkMessage
{

public const uint Id = 6543;
public override uint MessageId
{
    get { return Id; }
}

public int requestId;
        

public GameFightPlacementSwapPositionsCancelMessage()
{
}

public GameFightPlacementSwapPositionsCancelMessage(int requestId)
        {
            this.requestId = requestId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(requestId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

requestId = reader.ReadInt();
            if (requestId < 0)
                throw new Exception("Forbidden value on requestId = " + requestId + ", it doesn't respect the following condition : requestId < 0");
            

}


}


}