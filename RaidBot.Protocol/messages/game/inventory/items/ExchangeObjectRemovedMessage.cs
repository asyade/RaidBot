using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeObjectRemovedMessage : ExchangeObjectMessage
{

	public const uint Id = 5517;
	public override uint MessageId { get { return Id; } }

	public int ObjectUID { get; set; }

	public ExchangeObjectRemovedMessage() {}


	public ExchangeObjectRemovedMessage InitExchangeObjectRemovedMessage(int ObjectUID)
	{
		this.ObjectUID = ObjectUID;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.ObjectUID);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.ObjectUID = reader.ReadVarInt();
	}
}
}
