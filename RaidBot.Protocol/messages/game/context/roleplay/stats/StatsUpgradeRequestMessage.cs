using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class StatsUpgradeRequestMessage : NetworkMessage
{

	public const uint Id = 5610;
	public override uint MessageId { get { return Id; } }

	public bool UseAdditionnal { get; set; }
	public byte StatId { get; set; }
	public short BoostPoint { get; set; }

	public StatsUpgradeRequestMessage() {}


	public StatsUpgradeRequestMessage InitStatsUpgradeRequestMessage(bool UseAdditionnal, byte StatId, short BoostPoint)
	{
		this.UseAdditionnal = UseAdditionnal;
		this.StatId = StatId;
		this.BoostPoint = BoostPoint;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.UseAdditionnal);
		writer.WriteByte(this.StatId);
		writer.WriteVarShort(this.BoostPoint);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.UseAdditionnal = reader.ReadBoolean();
		this.StatId = reader.ReadByte();
		this.BoostPoint = reader.ReadVarShort();
	}
}
}
