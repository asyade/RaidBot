using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeObjectRemovedFromBagMessage : ExchangeObjectMessage
{

	public const uint Id = 6010;
	public override uint MessageId { get { return Id; } }

	public int ObjectUID { get; set; }

	public ExchangeObjectRemovedFromBagMessage() {}


	public ExchangeObjectRemovedFromBagMessage InitExchangeObjectRemovedFromBagMessage(int ObjectUID)
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
