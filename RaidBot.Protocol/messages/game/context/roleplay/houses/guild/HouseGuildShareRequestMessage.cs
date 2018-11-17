using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseGuildShareRequestMessage : NetworkMessage
{

	public const uint Id = 5704;
	public override uint MessageId { get { return Id; } }

	public int HouseId { get; set; }
	public int InstanceId { get; set; }
	public bool Enable { get; set; }
	public int Rights { get; set; }

	public HouseGuildShareRequestMessage() {}


	public HouseGuildShareRequestMessage InitHouseGuildShareRequestMessage(int HouseId, int InstanceId, bool Enable, int Rights)
	{
		this.HouseId = HouseId;
		this.InstanceId = InstanceId;
		this.Enable = Enable;
		this.Rights = Rights;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.HouseId);
		writer.WriteInt(this.InstanceId);
		writer.WriteBoolean(this.Enable);
		writer.WriteVarInt(this.Rights);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HouseId = reader.ReadVarInt();
		this.InstanceId = reader.ReadInt();
		this.Enable = reader.ReadBoolean();
		this.Rights = reader.ReadVarInt();
	}
}
}
