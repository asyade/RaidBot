


















// Generated on 06/26/2015 11:41:18
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ChallengeTargetsListRequestMessage : NetworkMessage
{

public const uint Id = 5614;
public override uint MessageId
{
    get { return Id; }
}

public ushort challengeId;
        

public ChallengeTargetsListRequestMessage()
{
}

public ChallengeTargetsListRequestMessage(ushort challengeId)
        {
            this.challengeId = challengeId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(challengeId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

challengeId = reader.ReadVaruhshort();
            if (challengeId < 0)
                throw new Exception("Forbidden value on challengeId = " + challengeId + ", it doesn't respect the following condition : challengeId < 0");
            

}


}


}