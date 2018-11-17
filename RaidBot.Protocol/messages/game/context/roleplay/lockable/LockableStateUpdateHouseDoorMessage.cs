using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LockableStateUpdateHouseDoorMessage : LockableStateUpdateAbstractMessage
{

	public const uint Id = 5668;
	public override uint MessageId { get { return Id; } }

	public int HouseId { get; set; }
	public int InstanceId { get; set; }
	public bool SecondHand { get; set; }

	public LockableStateUpdateHouseDoorMessage() {}


	public LockableStateUpdateHouseDoorMessage InitLockableStateUpdateHouseDoorMessage(int HouseId, int InstanceId, bool SecondHand)
	{
		this.HouseId = HouseId;
		this.InstanceId = InstanceId;
		this.SecondHand = SecondHand;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.HouseId);
		writer.WriteInt(this.InstanceId);
		writer.WriteBoolean(this.SecondHand);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.HouseId = reader.ReadVarInt();
		this.InstanceId = reader.ReadInt();
		this.SecondHand = reader.ReadBoolean();
	}
}
}
