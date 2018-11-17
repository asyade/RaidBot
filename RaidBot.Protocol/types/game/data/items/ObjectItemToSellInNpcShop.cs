using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectItemToSellInNpcShop : ObjectItemMinimalInformation
{

	public const uint Id = 352;
	public override uint MessageId { get { return Id; } }

	public long ObjectPrice { get; set; }
	public String BuyCriterion { get; set; }

	public ObjectItemToSellInNpcShop() {}


	public ObjectItemToSellInNpcShop InitObjectItemToSellInNpcShop(long ObjectPrice, String BuyCriterion)
	{
		this.ObjectPrice = ObjectPrice;
		this.BuyCriterion = BuyCriterion;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.ObjectPrice);
		writer.WriteUTF(this.BuyCriterion);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.ObjectPrice = reader.ReadVarLong();
		this.BuyCriterion = reader.ReadUTF();
	}
}
}
