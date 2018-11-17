using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseGuildRightsViewMessage : NetworkMessage
{

	public const uint Id = 5700;
	public override uint MessageId { get { return Id; } }

	public int HouseId { get; set; }
	public int InstanceId { get; set; }

	public HouseGuildRightsViewMessage() {}


	public HouseGuildRightsViewMessage InitHouseGuildRightsViewMessage(int HouseId, int InstanceId)
	{
		this.HouseId = HouseId;
		this.InstanceId = InstanceId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.HouseId);
		writer.WriteInt(this.InstanceId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HouseId = reader.ReadVarInt();
		this.InstanceId = reader.ReadInt();
	}
}
}
