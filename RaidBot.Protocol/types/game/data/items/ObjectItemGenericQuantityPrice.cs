using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectItemGenericQuantityPrice : ObjectItemGenericQuantity
{

	public const uint Id = 494;
	public override uint MessageId { get { return Id; } }

	public long Price { get; set; }

	public ObjectItemGenericQuantityPrice() {}


	public ObjectItemGenericQuantityPrice InitObjectItemGenericQuantityPrice(long Price)
	{
		this.Price = Price;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.Price);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Price = reader.ReadVarLong();
	}
}
}
