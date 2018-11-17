using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ArenaRankInfos : NetworkType
{

	public const uint Id = 499;
	public override uint MessageId { get { return Id; } }

	public ArenaRanking Ranking { get; set; }
	public ArenaLeagueRanking LeagueRanking { get; set; }
	public short VictoryCount { get; set; }
	public short Fightcount { get; set; }
	public short NumFightNeededForLadder { get; set; }

	public ArenaRankInfos() {}


	public ArenaRankInfos InitArenaRankInfos(ArenaRanking Ranking, ArenaLeagueRanking LeagueRanking, short VictoryCount, short Fightcount, short NumFightNeededForLadder)
	{
		this.Ranking = Ranking;
		this.LeagueRanking = LeagueRanking;
		this.VictoryCount = VictoryCount;
		this.Fightcount = Fightcount;
		this.NumFightNeededForLadder = NumFightNeededForLadder;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Ranking.Serialize(writer);
		this.LeagueRanking.Serialize(writer);
		writer.WriteVarShort(this.VictoryCount);
		writer.WriteVarShort(this.Fightcount);
		writer.WriteShort(this.NumFightNeededForLadder);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Ranking = new ArenaRanking();
		this.Ranking.Deserialize(reader);
		this.LeagueRanking = new ArenaLeagueRanking();
		this.LeagueRanking.Deserialize(reader);
		this.VictoryCount = reader.ReadVarShort();
		this.Fightcount = reader.ReadVarShort();
		this.NumFightNeededForLadder = reader.ReadShort();
	}
}
}
