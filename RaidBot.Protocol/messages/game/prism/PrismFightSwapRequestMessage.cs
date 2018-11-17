using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismFightSwapRequestMessage : NetworkMessage
{

	public const uint Id = 5901;
	public override uint MessageId { get { return Id; } }

	public short SubAreaId { get; set; }
	public long TargetId { get; set; }

	public PrismFightSwapRequestMessage() {}


	public PrismFightSwapRequestMessage InitPrismFightSwapRequestMessage(short SubAreaId, long TargetId)
	{
		this.SubAreaId = SubAreaId;
		this.TargetId = TargetId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteVarLong(this.TargetId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SubAreaId = reader.ReadVarShort();
		this.TargetId = reader.ReadVarLong();
	}
}
}
