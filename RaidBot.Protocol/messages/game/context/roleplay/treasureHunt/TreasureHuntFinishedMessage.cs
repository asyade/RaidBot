using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TreasureHuntFinishedMessage : NetworkMessage
{

	public const uint Id = 6483;
	public override uint MessageId { get { return Id; } }

	public byte QuestType { get; set; }

	public TreasureHuntFinishedMessage() {}


	public TreasureHuntFinishedMessage InitTreasureHuntFinishedMessage(byte QuestType)
	{
		this.QuestType = QuestType;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.QuestType);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.QuestType = reader.ReadByte();
	}
}
}
