using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseInstanceInformations : NetworkType
{

	public const uint Id = 511;
	public override uint MessageId { get { return Id; } }

	public bool SecondHand { get; set; }
	public bool IsLocked { get; set; }
	public bool IsSaleLocked { get; set; }
	public int InstanceId { get; set; }
	public String OwnerName { get; set; }
	public long Price { get; set; }

	public HouseInstanceInformations() {}


	public HouseInstanceInformations InitHouseInstanceInformations(bool SecondHand, bool IsLocked, bool IsSaleLocked, int InstanceId, String OwnerName, long Price)
	{
		this.SecondHand = SecondHand;
		this.IsLocked = IsLocked;
		this.IsSaleLocked = IsSaleLocked;
		this.InstanceId = InstanceId;
		this.OwnerName = OwnerName;
		this.Price = Price;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, SecondHand);
		box = BooleanByteWrapper.SetFlag(box, 1, IsLocked);
		box = BooleanByteWrapper.SetFlag(box, 2, IsSaleLocked);
		writer.WriteByte(box);
		writer.WriteInt(this.InstanceId);
		writer.WriteUTF(this.OwnerName);
		writer.WriteVarLong(this.Price);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		byte box = reader.ReadByte();
		this.SecondHand = BooleanByteWrapper.GetFlag(box, 0);
		this.IsLocked = BooleanByteWrapper.GetFlag(box, 1);
		this.IsSaleLocked = BooleanByteWrapper.GetFlag(box, 2);
		this.InstanceId = reader.ReadInt();
		this.OwnerName = reader.ReadUTF();
		this.Price = reader.ReadVarLong();
	}
}
}
