using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectItemToSellInBid : ObjectItemToSell
{

	public const uint Id = 164;
	public override uint MessageId { get { return Id; } }

	public int UnsoldDelay { get; set; }

	public ObjectItemToSellInBid() {}


	public ObjectItemToSellInBid InitObjectItemToSellInBid(int UnsoldDelay)
	{
		this.UnsoldDelay = UnsoldDelay;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteInt(this.UnsoldDelay);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.UnsoldDelay = reader.ReadInt();
	}
}
}
