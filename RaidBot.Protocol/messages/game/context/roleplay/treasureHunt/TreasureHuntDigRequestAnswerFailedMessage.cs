using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TreasureHuntDigRequestAnswerFailedMessage : TreasureHuntDigRequestAnswerMessage
{

	public const uint Id = 6509;
	public override uint MessageId { get { return Id; } }

	public byte WrongFlagCount { get; set; }

	public TreasureHuntDigRequestAnswerFailedMessage() {}


	public TreasureHuntDigRequestAnswerFailedMessage InitTreasureHuntDigRequestAnswerFailedMessage(byte WrongFlagCount)
	{
		this.WrongFlagCount = WrongFlagCount;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.WrongFlagCount);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.WrongFlagCount = reader.ReadByte();
	}
}
}
