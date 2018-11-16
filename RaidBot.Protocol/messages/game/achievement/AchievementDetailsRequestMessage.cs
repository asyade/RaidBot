


















// Generated on 06/26/2015 11:40:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AchievementDetailsRequestMessage : NetworkMessage
{

public const uint Id = 6380;
public override uint MessageId
{
    get { return Id; }
}

public ushort achievementId;
        

public AchievementDetailsRequestMessage()
{
}

public AchievementDetailsRequestMessage(ushort achievementId)
        {
            this.achievementId = achievementId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(achievementId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

achievementId = reader.ReadVaruhshort();
            if (achievementId < 0)
                throw new Exception("Forbidden value on achievementId = " + achievementId + ", it doesn't respect the following condition : achievementId < 0");
            

}


}


}