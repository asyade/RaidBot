using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectUseMultipleMessage : ObjectUseMessage
{

	public const uint Id = 6234;
	public override uint MessageId { get { return Id; } }

	public int Quantity { get; set; }

	public ObjectUseMultipleMessage() {}


	public ObjectUseMultipleMessage InitObjectUseMultipleMessage(int Quantity)
	{
		this.Quantity = Quantity;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.Quantity);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Quantity = reader.ReadVarInt();
	}
}
}
