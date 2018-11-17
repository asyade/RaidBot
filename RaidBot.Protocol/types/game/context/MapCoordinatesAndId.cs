using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MapCoordinatesAndId : MapCoordinates
{

	public const uint Id = 392;
	public override uint MessageId { get { return Id; } }

	public double MapId { get; set; }

	public MapCoordinatesAndId() {}


	public MapCoordinatesAndId InitMapCoordinatesAndId(double MapId)
	{
		this.MapId = MapId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.MapId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.MapId = reader.ReadDouble();
	}
}
}
