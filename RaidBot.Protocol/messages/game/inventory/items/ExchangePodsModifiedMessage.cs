using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangePodsModifiedMessage : ExchangeObjectMessage
{

	public const uint Id = 6670;
	public override uint MessageId { get { return Id; } }

	public int CurrentWeight { get; set; }
	public int MaxWeight { get; set; }

	public ExchangePodsModifiedMessage() {}


	public ExchangePodsModifiedMessage InitExchangePodsModifiedMessage(int CurrentWeight, int MaxWeight)
	{
		this.CurrentWeight = CurrentWeight;
		this.MaxWeight = MaxWeight;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.CurrentWeight);
		writer.WriteVarInt(this.MaxWeight);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.CurrentWeight = reader.ReadVarInt();
		this.MaxWeight = reader.ReadVarInt();
	}
}
}
