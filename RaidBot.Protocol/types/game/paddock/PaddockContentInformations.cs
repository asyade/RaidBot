using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PaddockContentInformations : PaddockInformations
{

	public const uint Id = 183;
	public override uint MessageId { get { return Id; } }

	public double PaddockId { get; set; }
	public short WorldX { get; set; }
	public short WorldY { get; set; }
	public double MapId { get; set; }
	public short SubAreaId { get; set; }
	public bool Abandonned { get; set; }
	public MountInformationsForPaddock[] MountsInformations { get; set; }

	public PaddockContentInformations() {}


	public PaddockContentInformations InitPaddockContentInformations(double PaddockId, short WorldX, short WorldY, double MapId, short SubAreaId, bool Abandonned, MountInformationsForPaddock[] MountsInformations)
	{
		this.PaddockId = PaddockId;
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		this.MapId = MapId;
		this.SubAreaId = SubAreaId;
		this.Abandonned = Abandonned;
		this.MountsInformations = MountsInformations;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.PaddockId);
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
		writer.WriteDouble(this.MapId);
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteBoolean(this.Abandonned);
		writer.WriteShort(this.MountsInformations.Length);
		foreach (MountInformationsForPaddock item in this.MountsInformations)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.PaddockId = reader.ReadDouble();
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
		this.MapId = reader.ReadDouble();
		this.SubAreaId = reader.ReadVarShort();
		this.Abandonned = reader.ReadBoolean();
		int MountsInformationsLen = reader.ReadShort();
		MountsInformations = new MountInformationsForPaddock[MountsInformationsLen];
		for (int i = 0; i < MountsInformationsLen; i++)
		{
			this.MountsInformations[i] = new MountInformationsForPaddock();
			this.MountsInformations[i].Deserialize(reader);
		}
	}
}
}
