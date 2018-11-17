using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightMinimalStatsPreparation : GameFightMinimalStats
{

	public const uint Id = 360;
	public override uint MessageId { get { return Id; } }

	public int Initiative { get; set; }

	public GameFightMinimalStatsPreparation() {}


	public GameFightMinimalStatsPreparation InitGameFightMinimalStatsPreparation(int Initiative)
	{
		this.Initiative = Initiative;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.Initiative);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Initiative = reader.ReadVarInt();
	}
}
}
