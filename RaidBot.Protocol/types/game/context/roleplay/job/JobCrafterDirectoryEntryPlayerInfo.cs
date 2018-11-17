using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobCrafterDirectoryEntryPlayerInfo : NetworkType
{

	public const uint Id = 194;
	public override uint MessageId { get { return Id; } }

	public long PlayerId { get; set; }
	public String PlayerName { get; set; }
	public byte AlignmentSide { get; set; }
	public byte Breed { get; set; }
	public bool Sex { get; set; }
	public bool IsInWorkshop { get; set; }
	public short WorldX { get; set; }
	public short WorldY { get; set; }
	public double MapId { get; set; }
	public short SubAreaId { get; set; }

	public JobCrafterDirectoryEntryPlayerInfo() {}


	public JobCrafterDirectoryEntryPlayerInfo InitJobCrafterDirectoryEntryPlayerInfo(long PlayerId, String PlayerName, byte AlignmentSide, byte Breed, bool Sex, bool IsInWorkshop, short WorldX, short WorldY, double MapId, short SubAreaId)
	{
		this.PlayerId = PlayerId;
		this.PlayerName = PlayerName;
		this.AlignmentSide = AlignmentSide;
		this.Breed = Breed;
		this.Sex = Sex;
		this.IsInWorkshop = IsInWorkshop;
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		this.MapId = MapId;
		this.SubAreaId = SubAreaId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.PlayerId);
		writer.WriteUTF(this.PlayerName);
		writer.WriteByte(this.AlignmentSide);
		writer.WriteByte(this.Breed);
		writer.WriteBoolean(this.Sex);
		writer.WriteBoolean(this.IsInWorkshop);
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
		writer.WriteDouble(this.MapId);
		writer.WriteVarShort(this.SubAreaId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PlayerId = reader.ReadVarLong();
		this.PlayerName = reader.ReadUTF();
		this.AlignmentSide = reader.ReadByte();
		this.Breed = reader.ReadByte();
		this.Sex = reader.ReadBoolean();
		this.IsInWorkshop = reader.ReadBoolean();
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
		this.MapId = reader.ReadDouble();
		this.SubAreaId = reader.ReadVarShort();
	}
}
}
