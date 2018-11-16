


















// Generated on 06/26/2015 11:41:16
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightPlacementSwapPositionsCancelledMessage : NetworkMessage
{

public const uint Id = 6546;
public override uint MessageId
{
    get { return Id; }
}

public int requestId;
        public uint cancellerId;
        

public GameFightPlacementSwapPositionsCancelledMessage()
{
}

public GameFightPlacementSwapPositionsCancelledMessage(int requestId, uint cancellerId)
        {
            this.requestId = requestId;
            this.cancellerId = cancellerId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(requestId);
            writer.WriteVaruhint(cancellerId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

requestId = reader.ReadInt();
            if (requestId < 0)
                throw new Exception("Forbidden value on requestId = " + requestId + ", it doesn't respect the following condition : requestId < 0");
            cancellerId = reader.ReadVaruhint();
            if (cancellerId < 0)
                throw new Exception("Forbidden value on cancellerId = " + cancellerId + ", it doesn't respect the following condition : cancellerId < 0");
            

}


}


}