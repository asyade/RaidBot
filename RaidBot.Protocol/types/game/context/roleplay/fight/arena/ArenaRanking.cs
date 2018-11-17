using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ArenaRanking : NetworkType
{

	public const uint Id = 554;
	public override uint MessageId { get { return Id; } }

	public short Rank { get; set; }
	public short BestRank { get; set; }

	public ArenaRanking() {}


	public ArenaRanking InitArenaRanking(short Rank, short BestRank)
	{
		this.Rank = Rank;
		this.BestRank = BestRank;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.Rank);
		writer.WriteVarShort(this.BestRank);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Rank = reader.ReadVarShort();
		this.BestRank = reader.ReadVarShort();
	}
}
}
