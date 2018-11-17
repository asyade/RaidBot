using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseBuyResultMessage : NetworkMessage
{

	public const uint Id = 5735;
	public override uint MessageId { get { return Id; } }

	public bool SecondHand { get; set; }
	public bool Bought { get; set; }
	public int HouseId { get; set; }
	public int InstanceId { get; set; }
	public long RealPrice { get; set; }

	public HouseBuyResultMessage() {}


	public HouseBuyResultMessage InitHouseBuyResultMessage(bool SecondHand, bool Bought, int HouseId, int InstanceId, long RealPrice)
	{
		this.SecondHand = SecondHand;
		this.Bought = Bought;
		this.HouseId = HouseId;
		this.InstanceId = InstanceId;
		this.RealPrice = RealPrice;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, SecondHand);
		box = BooleanByteWrapper.SetFlag(box, 1, Bought);
		writer.WriteByte(box);
		writer.WriteVarInt(this.HouseId);
		writer.WriteInt(this.InstanceId);
		writer.WriteVarLong(this.RealPrice);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		byte box = reader.ReadByte();
		this.SecondHand = BooleanByteWrapper.GetFlag(box, 0);
		this.Bought = BooleanByteWrapper.GetFlag(box, 1);
		this.HouseId = reader.ReadVarInt();
		this.InstanceId = reader.ReadInt();
		this.RealPrice = reader.ReadVarLong();
	}
}
}
