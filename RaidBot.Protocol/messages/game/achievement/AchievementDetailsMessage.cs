


















// Generated on 06/26/2015 11:40:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AchievementDetailsMessage : NetworkMessage
{

public const uint Id = 6378;
public override uint MessageId
{
    get { return Id; }
}

public Types.Achievement achievement;
        

public AchievementDetailsMessage()
{
}

public AchievementDetailsMessage(Types.Achievement achievement)
        {
            this.achievement = achievement;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

achievement.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

achievement = new Types.Achievement();
            achievement.Deserialize(reader);
            

}


}


}