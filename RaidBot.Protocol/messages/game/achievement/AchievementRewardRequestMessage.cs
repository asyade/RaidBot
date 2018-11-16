


















// Generated on 06/26/2015 11:41:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AchievementRewardRequestMessage : NetworkMessage
{

public const uint Id = 6377;
public override uint MessageId
{
    get { return Id; }
}

public short achievementId;
        

public AchievementRewardRequestMessage()
{
}

public AchievementRewardRequestMessage(short achievementId)
        {
            this.achievementId = achievementId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(achievementId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

achievementId = reader.ReadShort();
            

}


}


}