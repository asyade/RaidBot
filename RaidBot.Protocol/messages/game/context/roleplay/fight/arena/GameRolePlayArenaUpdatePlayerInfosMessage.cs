


















// Generated on 06/26/2015 11:41:24
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayArenaUpdatePlayerInfosMessage : NetworkMessage
{

public const uint Id = 6301;
public override uint MessageId
{
    get { return Id; }
}

public ushort rank;
        public ushort bestDailyRank;
        public ushort bestRank;
        public ushort victoryCount;
        public ushort arenaFightcount;
        

public GameRolePlayArenaUpdatePlayerInfosMessage()
{
}

public GameRolePlayArenaUpdatePlayerInfosMessage(ushort rank, ushort bestDailyRank, ushort bestRank, ushort victoryCount, ushort arenaFightcount)
        {
            this.rank = rank;
            this.bestDailyRank = bestDailyRank;
            this.bestRank = bestRank;
            this.victoryCount = victoryCount;
            this.arenaFightcount = arenaFightcount;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(rank);
            writer.WriteVaruhshort(bestDailyRank);
            writer.WriteVaruhshort(bestRank);
            writer.WriteVaruhshort(victoryCount);
            writer.WriteVaruhshort(arenaFightcount);
            

}

public override void Deserialize(ICustomDataReader reader)
{

rank = reader.ReadVaruhshort();
            if (rank < 0 || rank > 2300)
                throw new Exception("Forbidden value on rank = " + rank + ", it doesn't respect the following condition : rank < 0 || rank > 2300");
            bestDailyRank = reader.ReadVaruhshort();
            if (bestDailyRank < 0 || bestDailyRank > 2300)
                throw new Exception("Forbidden value on bestDailyRank = " + bestDailyRank + ", it doesn't respect the following condition : bestDailyRank < 0 || bestDailyRank > 2300");
            bestRank = reader.ReadVaruhshort();
            if (bestRank < 0 || bestRank > 2300)
                throw new Exception("Forbidden value on bestRank = " + bestRank + ", it doesn't respect the following condition : bestRank < 0 || bestRank > 2300");
            victoryCount = reader.ReadVaruhshort();
            if (victoryCount < 0)
                throw new Exception("Forbidden value on victoryCount = " + victoryCount + ", it doesn't respect the following condition : victoryCount < 0");
            arenaFightcount = reader.ReadVaruhshort();
            if (arenaFightcount < 0)
                throw new Exception("Forbidden value on arenaFightcount = " + arenaFightcount + ", it doesn't respect the following condition : arenaFightcount < 0");
            

}


}


}