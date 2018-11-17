using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseSellRequestMessage : NetworkMessage
{

	public const uint Id = 5697;
	public override uint MessageId { get { return Id; } }

	public int InstanceId { get; set; }
	public long Amount { get; set; }
	public bool ForSale { get; set; }

	public HouseSellRequestMessage() {}


	public HouseSellRequestMessage InitHouseSellRequestMessage(int InstanceId, long Amount, bool ForSale)
	{
		this.InstanceId = InstanceId;
		this.Amount = Amount;
		this.ForSale = ForSale;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.InstanceId);
		writer.WriteVarLong(this.Amount);
		writer.WriteBoolean(this.ForSale);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.InstanceId = reader.ReadInt();
		this.Amount = reader.ReadVarLong();
		this.ForSale = reader.ReadBoolean();
	}
}
}
