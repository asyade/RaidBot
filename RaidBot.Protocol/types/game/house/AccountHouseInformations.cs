using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AccountHouseInformations : HouseInformations
{

	public const uint Id = 390;
	public override uint MessageId { get { return Id; } }

	public short WorldX { get; set; }
	public short WorldY { get; set; }
	public double MapId { get; set; }
	public short SubAreaId { get; set; }

	public AccountHouseInformations() {}


	public AccountHouseInformations InitAccountHouseInformations(short WorldX, short WorldY, double MapId, short SubAreaId)
	{
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		this.MapId = MapId;
		this.SubAreaId = SubAreaId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
		writer.WriteDouble(this.MapId);
		writer.WriteVarShort(this.SubAreaId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
		this.MapId = reader.ReadDouble();
		this.SubAreaId = reader.ReadVarShort();
	}
}
}
