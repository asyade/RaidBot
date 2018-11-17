using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseTeleportRequestMessage : NetworkMessage
{

	public const uint Id = 6726;
	public override uint MessageId { get { return Id; } }

	public int HouseId { get; set; }
	public int HouseInstanceId { get; set; }

	public HouseTeleportRequestMessage() {}


	public HouseTeleportRequestMessage InitHouseTeleportRequestMessage(int HouseId, int HouseInstanceId)
	{
		this.HouseId = HouseId;
		this.HouseInstanceId = HouseInstanceId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.HouseId);
		writer.WriteInt(this.HouseInstanceId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HouseId = reader.ReadVarInt();
		this.HouseInstanceId = reader.ReadInt();
	}
}
}
