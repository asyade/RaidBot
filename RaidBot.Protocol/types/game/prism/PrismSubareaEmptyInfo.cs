using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismSubareaEmptyInfo : NetworkType
{

	public const uint Id = 438;
	public override uint MessageId { get { return Id; } }

	public short SubAreaId { get; set; }
	public int AllianceId { get; set; }

	public PrismSubareaEmptyInfo() {}


	public PrismSubareaEmptyInfo InitPrismSubareaEmptyInfo(short SubAreaId, int AllianceId)
	{
		this.SubAreaId = SubAreaId;
		this.AllianceId = AllianceId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteVarInt(this.AllianceId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SubAreaId = reader.ReadVarShort();
		this.AllianceId = reader.ReadVarInt();
	}
}
}
