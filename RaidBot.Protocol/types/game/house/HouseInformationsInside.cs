using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseInformationsInside : HouseInformations
{

	public const uint Id = 218;
	public override uint MessageId { get { return Id; } }

	public short WorldX { get; set; }
	public short WorldY { get; set; }

	public HouseInformationsInside() {}


	public HouseInformationsInside InitHouseInformationsInside(short WorldX, short WorldY)
	{
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
	}
}
}
