using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismSettingsRequestMessage : NetworkMessage
{

	public const uint Id = 6437;
	public override uint MessageId { get { return Id; } }

	public short SubAreaId { get; set; }
	public byte StartDefenseTime { get; set; }

	public PrismSettingsRequestMessage() {}


	public PrismSettingsRequestMessage InitPrismSettingsRequestMessage(short SubAreaId, byte StartDefenseTime)
	{
		this.SubAreaId = SubAreaId;
		this.StartDefenseTime = StartDefenseTime;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteByte(this.StartDefenseTime);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SubAreaId = reader.ReadVarShort();
		this.StartDefenseTime = reader.ReadByte();
	}
}
}
