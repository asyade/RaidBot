


















// Generated on 06/26/2015 11:41:16
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightPlacementSwapPositionsRequestMessage : GameFightPlacementPositionRequestMessage
{

public const uint Id = 6541;
public override uint MessageId
{
    get { return Id; }
}

public int requestedId;
        

public GameFightPlacementSwapPositionsRequestMessage()
{
}

public GameFightPlacementSwapPositionsRequestMessage(ushort cellId, int requestedId)
         : base(cellId)
        {
            this.requestedId = requestedId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(requestedId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            requestedId = reader.ReadInt();
            

}


}


}