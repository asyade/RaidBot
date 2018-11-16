


















// Generated on 06/26/2015 11:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyFollowStatusUpdateMessage : AbstractPartyMessage
{

public const uint Id = 5581;
public override uint MessageId
{
    get { return Id; }
}

public bool success;
        public uint followedId;
        

public PartyFollowStatusUpdateMessage()
{
}

public PartyFollowStatusUpdateMessage(uint partyId, bool success, uint followedId)
         : base(partyId)
        {
            this.success = success;
            this.followedId = followedId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(success);
            writer.WriteVaruhint(followedId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            success = reader.ReadBoolean();
            followedId = reader.ReadVaruhint();
            if (followedId < 0)
                throw new Exception("Forbidden value on followedId = " + followedId + ", it doesn't respect the following condition : followedId < 0");
            

}


}


}