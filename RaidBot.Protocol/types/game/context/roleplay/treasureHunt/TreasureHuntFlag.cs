using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TreasureHuntFlag : NetworkType
{

	public const uint Id = 473;
	public override uint MessageId { get { return Id; } }

	public double MapId { get; set; }
	public byte State { get; set; }

	public TreasureHuntFlag() {}


	public TreasureHuntFlag InitTreasureHuntFlag(double MapId, byte State)
	{
		this.MapId = MapId;
		this.State = State;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.MapId);
		writer.WriteByte(this.State);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MapId = reader.ReadDouble();
		this.State = reader.ReadByte();
	}
}
}
