using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class StatsUpgradeResultMessage : NetworkMessage
{

	public const uint Id = 5609;
	public override uint MessageId { get { return Id; } }

	public byte Result { get; set; }
	public short NbCharacBoost { get; set; }

	public StatsUpgradeResultMessage() {}


	public StatsUpgradeResultMessage InitStatsUpgradeResultMessage(byte Result, short NbCharacBoost)
	{
		this.Result = Result;
		this.NbCharacBoost = NbCharacBoost;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Result);
		writer.WriteVarShort(this.NbCharacBoost);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Result = reader.ReadByte();
		this.NbCharacBoost = reader.ReadVarShort();
	}
}
}
