using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MapCoordinates : NetworkType
{

	public const uint Id = 174;
	public override uint MessageId { get { return Id; } }

	public short WorldX { get; set; }
	public short WorldY { get; set; }

	public MapCoordinates() {}


	public MapCoordinates InitMapCoordinates(short WorldX, short WorldY)
	{
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
	}
}
}
