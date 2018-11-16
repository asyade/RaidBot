


















// Generated on 06/26/2015 11:41:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AchievementListMessage : NetworkMessage
{

public const uint Id = 6205;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] finishedAchievementsIds;
        public Types.AchievementRewardable[] rewardableAchievements;
        

public AchievementListMessage()
{
}

public AchievementListMessage(ushort[] finishedAchievementsIds, Types.AchievementRewardable[] rewardableAchievements)
        {
            this.finishedAchievementsIds = finishedAchievementsIds;
            this.rewardableAchievements = rewardableAchievements;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)finishedAchievementsIds.Length);
            foreach (var entry in finishedAchievementsIds)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)rewardableAchievements.Length);
            foreach (var entry in rewardableAchievements)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            finishedAchievementsIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishedAchievementsIds[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            rewardableAchievements = new Types.AchievementRewardable[limit];
            for (int i = 0; i < limit; i++)
            {
                 rewardableAchievements[i] = new Types.AchievementRewardable();
                 rewardableAchievements[i].Deserialize(reader);
            }
            

}


}


}