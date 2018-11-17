using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObtainedItemMessage : NetworkMessage
{

	public const uint Id = 6519;
	public override uint MessageId { get { return Id; } }

	public short GenericId { get; set; }
	public int BaseQuantity { get; set; }

	public ObtainedItemMessage() {}


	public ObtainedItemMessage InitObtainedItemMessage(short GenericId, int BaseQuantity)
	{
		this.GenericId = GenericId;
		this.BaseQuantity = BaseQuantity;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.GenericId);
		writer.WriteVarInt(this.BaseQuantity);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.GenericId = reader.ReadVarShort();
		this.BaseQuantity = reader.ReadVarInt();
	}
}
}
