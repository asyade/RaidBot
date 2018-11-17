using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DareReward : NetworkType
{

	public const uint Id = 505;
	public override uint MessageId { get { return Id; } }

	public byte Type { get; set; }
	public short MonsterId { get; set; }
	public long Kamas { get; set; }
	public double DareId { get; set; }

	public DareReward() {}


	public DareReward InitDareReward(byte Type, short MonsterId, long Kamas, double DareId)
	{
		this.Type = Type;
		this.MonsterId = MonsterId;
		this.Kamas = Kamas;
		this.DareId = DareId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Type);
		writer.WriteVarShort(this.MonsterId);
		writer.WriteVarLong(this.Kamas);
		writer.WriteDouble(this.DareId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Type = reader.ReadByte();
		this.MonsterId = reader.ReadVarShort();
		this.Kamas = reader.ReadVarLong();
		this.DareId = reader.ReadDouble();
	}
}
}
