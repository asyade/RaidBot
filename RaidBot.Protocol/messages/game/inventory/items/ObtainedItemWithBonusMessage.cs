using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObtainedItemWithBonusMessage : ObtainedItemMessage
{

	public const uint Id = 6520;
	public override uint MessageId { get { return Id; } }

	public int BonusQuantity { get; set; }

	public ObtainedItemWithBonusMessage() {}


	public ObtainedItemWithBonusMessage InitObtainedItemWithBonusMessage(int BonusQuantity)
	{
		this.BonusQuantity = BonusQuantity;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.BonusQuantity);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.BonusQuantity = reader.ReadVarInt();
	}
}
}
