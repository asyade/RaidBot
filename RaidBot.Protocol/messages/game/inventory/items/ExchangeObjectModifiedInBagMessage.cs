using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeObjectModifiedInBagMessage : ExchangeObjectMessage
{

	public const uint Id = 6008;
	public override uint MessageId { get { return Id; } }

	public ObjectItem Object { get; set; }

	public ExchangeObjectModifiedInBagMessage() {}


	public ExchangeObjectModifiedInBagMessage InitExchangeObjectModifiedInBagMessage(ObjectItem Object)
	{
		this.Object = Object;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.Object.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Object = new ObjectItem();
		this.Object.Deserialize(reader);
	}
}
}
