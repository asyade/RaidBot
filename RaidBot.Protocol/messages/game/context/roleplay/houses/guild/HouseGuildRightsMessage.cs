using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseGuildRightsMessage : NetworkMessage
{

	public const uint Id = 5703;
	public override uint MessageId { get { return Id; } }

	public int HouseId { get; set; }
	public int InstanceId { get; set; }
	public bool SecondHand { get; set; }
	public GuildInformations GuildInfo { get; set; }
	public int Rights { get; set; }

	public HouseGuildRightsMessage() {}


	public HouseGuildRightsMessage InitHouseGuildRightsMessage(int HouseId, int InstanceId, bool SecondHand, GuildInformations GuildInfo, int Rights)
	{
		this.HouseId = HouseId;
		this.InstanceId = InstanceId;
		this.SecondHand = SecondHand;
		this.GuildInfo = GuildInfo;
		this.Rights = Rights;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.HouseId);
		writer.WriteInt(this.InstanceId);
		writer.WriteBoolean(this.SecondHand);
		this.GuildInfo.Serialize(writer);
		writer.WriteVarInt(this.Rights);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HouseId = reader.ReadVarInt();
		this.InstanceId = reader.ReadInt();
		this.SecondHand = reader.ReadBoolean();
		this.GuildInfo = new GuildInformations();
		this.GuildInfo.Deserialize(reader);
		this.Rights = reader.ReadVarInt();
	}
}
}
