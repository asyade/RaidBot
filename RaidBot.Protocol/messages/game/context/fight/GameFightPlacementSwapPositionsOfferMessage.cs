


















// Generated on 06/26/2015 11:41:16
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightPlacementSwapPositionsOfferMessage : NetworkMessage
{

public const uint Id = 6542;
public override uint MessageId
{
    get { return Id; }
}

public int requestId;
        public uint requesterId;
        public ushort requesterCellId;
        public uint requestedId;
        public ushort requestedCellId;
        

public GameFightPlacementSwapPositionsOfferMessage()
{
}

public GameFightPlacementSwapPositionsOfferMessage(int requestId, uint requesterId, ushort requesterCellId, uint requestedId, ushort requestedCellId)
        {
            this.requestId = requestId;
            this.requesterId = requesterId;
            this.requesterCellId = requesterCellId;
            this.requestedId = requestedId;
            this.requestedCellId = requestedCellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(requestId);
            writer.WriteVaruhint(requesterId);
            writer.WriteVaruhshort(requesterCellId);
            writer.WriteVaruhint(requestedId);
            writer.WriteVaruhshort(requestedCellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

requestId = reader.ReadInt();
            if (requestId < 0)
                throw new Exception("Forbidden value on requestId = " + requestId + ", it doesn't respect the following condition : requestId < 0");
            requesterId = reader.ReadVaruhint();
            if (requesterId < 0)
                throw new Exception("Forbidden value on requesterId = " + requesterId + ", it doesn't respect the following condition : requesterId < 0");
            requesterCellId = reader.ReadVaruhshort();
            if (requesterCellId < 0 || requesterCellId > 559)
                throw new Exception("Forbidden value on requesterCellId = " + requesterCellId + ", it doesn't respect the following condition : requesterCellId < 0 || requesterCellId > 559");
            requestedId = reader.ReadVaruhint();
            if (requestedId < 0)
                throw new Exception("Forbidden value on requestedId = " + requestedId + ", it doesn't respect the following condition : requestedId < 0");
            requestedCellId = reader.ReadVaruhshort();
            if (requestedCellId < 0 || requestedCellId > 559)
                throw new Exception("Forbidden value on requestedCellId = " + requestedCellId + ", it doesn't respect the following condition : requestedCellId < 0 || requestedCellId > 559");
            

}


}


}