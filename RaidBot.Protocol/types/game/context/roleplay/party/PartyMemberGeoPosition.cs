using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyMemberGeoPosition : NetworkType
{

	public const uint Id = 378;
	public override uint MessageId { get { return Id; } }

	public int MemberId { get; set; }
	public short WorldX { get; set; }
	public short WorldY { get; set; }
	public double MapId { get; set; }
	public short SubAreaId { get; set; }

	public PartyMemberGeoPosition() {}


	public PartyMemberGeoPosition InitPartyMemberGeoPosition(int MemberId, short WorldX, short WorldY, double MapId, short SubAreaId)
	{
		this.MemberId = MemberId;
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		this.MapId = MapId;
		this.SubAreaId = SubAreaId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.MemberId);
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
		writer.WriteDouble(this.MapId);
		writer.WriteVarShort(this.SubAreaId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MemberId = reader.ReadInt();
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
		this.MapId = reader.ReadDouble();
		this.SubAreaId = reader.ReadVarShort();
	}
}
}
