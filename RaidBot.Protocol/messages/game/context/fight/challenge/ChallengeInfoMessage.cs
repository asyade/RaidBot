


















// Generated on 06/26/2015 11:41:18
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ChallengeInfoMessage : NetworkMessage
{

public const uint Id = 6022;
public override uint MessageId
{
    get { return Id; }
}

public ushort challengeId;
        public int targetId;
        public uint xpBonus;
        public uint dropBonus;
        

public ChallengeInfoMessage()
{
}

public ChallengeInfoMessage(ushort challengeId, int targetId, uint xpBonus, uint dropBonus)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
            this.xpBonus = xpBonus;
            this.dropBonus = dropBonus;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(challengeId);
            writer.WriteInt(targetId);
            writer.WriteVaruhint(xpBonus);
            writer.WriteVaruhint(dropBonus);
            

}

public override void Deserialize(ICustomDataReader reader)
{

challengeId = reader.ReadVaruhshort();
            if (challengeId < 0)
                throw new Exception("Forbidden value on challengeId = " + challengeId + ", it doesn't respect the following condition : challengeId < 0");
            targetId = reader.ReadInt();
            xpBonus = reader.ReadVaruhint();
            if (xpBonus < 0)
                throw new Exception("Forbidden value on xpBonus = " + xpBonus + ", it doesn't respect the following condition : xpBonus < 0");
            dropBonus = reader.ReadVaruhint();
            if (dropBonus < 0)
                throw new Exception("Forbidden value on dropBonus = " + dropBonus + ", it doesn't respect the following condition : dropBonus < 0");
            

}


}


}