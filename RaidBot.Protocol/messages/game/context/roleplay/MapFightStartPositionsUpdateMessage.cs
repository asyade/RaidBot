using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MapFightStartPositionsUpdateMessage : NetworkMessage
{

	public const uint Id = 6716;
	public override uint MessageId { get { return Id; } }

	public double MapId { get; set; }
	public FightStartingPositions FightStartPositions { get; set; }

	public MapFightStartPositionsUpdateMessage() {}


	public MapFightStartPositionsUpdateMessage InitMapFightStartPositionsUpdateMessage(double MapId, FightStartingPositions FightStartPositions)
	{
		this.MapId = MapId;
		this.FightStartPositions = FightStartPositions;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.MapId);
		this.FightStartPositions.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MapId = reader.ReadDouble();
		this.FightStartPositions = new FightStartingPositions();
		this.FightStartPositions.Deserialize(reader);
	}
}
}
