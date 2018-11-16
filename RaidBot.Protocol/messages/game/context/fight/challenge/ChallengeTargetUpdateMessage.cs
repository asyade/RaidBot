


















// Generated on 06/26/2015 11:41:18
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ChallengeTargetUpdateMessage : NetworkMessage
{

public const uint Id = 6123;
public override uint MessageId
{
    get { return Id; }
}

public ushort challengeId;
        public int targetId;
        

public ChallengeTargetUpdateMessage()
{
}

public ChallengeTargetUpdateMessage(ushort challengeId, int targetId)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(challengeId);
            writer.WriteInt(targetId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

challengeId = reader.ReadVaruhshort();
            if (challengeId < 0)
                throw new Exception("Forbidden value on challengeId = " + challengeId + ", it doesn't respect the following condition : challengeId < 0");
            targetId = reader.ReadInt();
            

}


}


}