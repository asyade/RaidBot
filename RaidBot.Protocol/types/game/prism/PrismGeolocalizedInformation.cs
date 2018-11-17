using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismGeolocalizedInformation : PrismSubareaEmptyInfo
{

	public const uint Id = 434;
	public override uint MessageId { get { return Id; } }

	public short WorldX { get; set; }
	public short WorldY { get; set; }
	public double MapId { get; set; }

	public PrismGeolocalizedInformation() {}


	public PrismGeolocalizedInformation InitPrismGeolocalizedInformation(short WorldX, short WorldY, double MapId)
	{
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		this.MapId = MapId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
		writer.WriteDouble(this.MapId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
		this.MapId = reader.ReadDouble();
	}
}
}
