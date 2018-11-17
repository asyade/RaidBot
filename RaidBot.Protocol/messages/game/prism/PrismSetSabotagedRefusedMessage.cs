using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismSetSabotagedRefusedMessage : NetworkMessage
{

	public const uint Id = 6466;
	public override uint MessageId { get { return Id; } }

	public short SubAreaId { get; set; }
	public byte Reason { get; set; }

	public PrismSetSabotagedRefusedMessage() {}


	public PrismSetSabotagedRefusedMessage InitPrismSetSabotagedRefusedMessage(short SubAreaId, byte Reason)
	{
		this.SubAreaId = SubAreaId;
		this.Reason = Reason;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteByte(this.Reason);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SubAreaId = reader.ReadVarShort();
		this.Reason = reader.ReadByte();
	}
}
}
