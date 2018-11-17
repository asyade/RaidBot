using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TreasureHuntAvailableRetryCountUpdateMessage : NetworkMessage
{

	public const uint Id = 6491;
	public override uint MessageId { get { return Id; } }

	public byte QuestType { get; set; }
	public int AvailableRetryCount { get; set; }

	public TreasureHuntAvailableRetryCountUpdateMessage() {}


	public TreasureHuntAvailableRetryCountUpdateMessage InitTreasureHuntAvailableRetryCountUpdateMessage(byte QuestType, int AvailableRetryCount)
	{
		this.QuestType = QuestType;
		this.AvailableRetryCount = AvailableRetryCount;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.QuestType);
		writer.WriteInt(this.AvailableRetryCount);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.QuestType = reader.ReadByte();
		this.AvailableRetryCount = reader.ReadInt();
	}
}
}
