using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TreasureHuntDigRequestMessage : NetworkMessage
{

	public const uint Id = 6485;
	public override uint MessageId { get { return Id; } }

	public byte QuestType { get; set; }

	public TreasureHuntDigRequestMessage() {}


	public TreasureHuntDigRequestMessage InitTreasureHuntDigRequestMessage(byte QuestType)
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
