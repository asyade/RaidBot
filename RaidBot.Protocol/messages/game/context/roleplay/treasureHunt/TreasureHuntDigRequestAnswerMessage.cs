using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TreasureHuntDigRequestAnswerMessage : NetworkMessage
{

	public const uint Id = 6484;
	public override uint MessageId { get { return Id; } }

	public byte QuestType { get; set; }
	public byte Result { get; set; }

	public TreasureHuntDigRequestAnswerMessage() {}


	public TreasureHuntDigRequestAnswerMessage InitTreasureHuntDigRequestAnswerMessage(byte QuestType, byte Result)
	{
		this.QuestType = QuestType;
		this.Result = Result;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.QuestType);
		writer.WriteByte(this.Result);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.QuestType = reader.ReadByte();
		this.Result = reader.ReadByte();
	}
}
}
