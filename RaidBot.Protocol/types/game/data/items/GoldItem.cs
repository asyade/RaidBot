using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GoldItem : Item
{

	public const uint Id = 123;
	public override uint MessageId { get { return Id; } }

	public long Sum { get; set; }

	public GoldItem() {}


	public GoldItem InitGoldItem(long Sum)
	{
		this.Sum = Sum;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.Sum);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Sum = reader.ReadVarLong();
	}
}
}
