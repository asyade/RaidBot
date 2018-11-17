using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MapObstacle : NetworkType
{

	public const uint Id = 200;
	public override uint MessageId { get { return Id; } }

	public short ObstacleCellId { get; set; }
	public byte State { get; set; }

	public MapObstacle() {}


	public MapObstacle InitMapObstacle(short ObstacleCellId, byte State)
	{
		this.ObstacleCellId = ObstacleCellId;
		this.State = State;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ObstacleCellId);
		writer.WriteByte(this.State);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ObstacleCellId = reader.ReadVarShort();
		this.State = reader.ReadByte();
	}
}
}
