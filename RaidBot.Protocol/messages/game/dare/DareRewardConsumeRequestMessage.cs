using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DareRewardConsumeRequestMessage : NetworkMessage
{

	public const uint Id = 6676;
	public override uint MessageId { get { return Id; } }

	public double DareId { get; set; }
	public byte Type { get; set; }

	public DareRewardConsumeRequestMessage() {}


	public DareRewardConsumeRequestMessage InitDareRewardConsumeRequestMessage(double DareId, byte Type)
	{
		this.DareId = DareId;
		this.Type = Type;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.DareId);
		writer.WriteByte(this.Type);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DareId = reader.ReadDouble();
		this.Type = reader.ReadByte();
	}
}
}
