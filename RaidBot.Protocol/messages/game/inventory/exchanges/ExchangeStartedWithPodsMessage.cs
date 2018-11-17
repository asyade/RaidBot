using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeStartedWithPodsMessage : ExchangeStartedMessage
{

	public const uint Id = 6129;
	public override uint MessageId { get { return Id; } }

	public double FirstCharacterId { get; set; }
	public int FirstCharacterCurrentWeight { get; set; }
	public int FirstCharacterMaxWeight { get; set; }
	public double SecondCharacterId { get; set; }
	public int SecondCharacterCurrentWeight { get; set; }
	public int SecondCharacterMaxWeight { get; set; }

	public ExchangeStartedWithPodsMessage() {}


	public ExchangeStartedWithPodsMessage InitExchangeStartedWithPodsMessage(double FirstCharacterId, int FirstCharacterCurrentWeight, int FirstCharacterMaxWeight, double SecondCharacterId, int SecondCharacterCurrentWeight, int SecondCharacterMaxWeight)
	{
		this.FirstCharacterId = FirstCharacterId;
		this.FirstCharacterCurrentWeight = FirstCharacterCurrentWeight;
		this.FirstCharacterMaxWeight = FirstCharacterMaxWeight;
		this.SecondCharacterId = SecondCharacterId;
		this.SecondCharacterCurrentWeight = SecondCharacterCurrentWeight;
		this.SecondCharacterMaxWeight = SecondCharacterMaxWeight;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.FirstCharacterId);
		writer.WriteVarInt(this.FirstCharacterCurrentWeight);
		writer.WriteVarInt(this.FirstCharacterMaxWeight);
		writer.WriteDouble(this.SecondCharacterId);
		writer.WriteVarInt(this.SecondCharacterCurrentWeight);
		writer.WriteVarInt(this.SecondCharacterMaxWeight);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.FirstCharacterId = reader.ReadDouble();
		this.FirstCharacterCurrentWeight = reader.ReadVarInt();
		this.FirstCharacterMaxWeight = reader.ReadVarInt();
		this.SecondCharacterId = reader.ReadDouble();
		this.SecondCharacterCurrentWeight = reader.ReadVarInt();
		this.SecondCharacterMaxWeight = reader.ReadVarInt();
	}
}
}
