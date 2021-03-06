using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseInformationsForGuild : HouseInformations
{

	public const uint Id = 170;
	public override uint MessageId { get { return Id; } }

	public int InstanceId { get; set; }
	public bool SecondHand { get; set; }
	public String OwnerName { get; set; }
	public short WorldX { get; set; }
	public short WorldY { get; set; }
	public double MapId { get; set; }
	public short SubAreaId { get; set; }
	public int[] SkillListIds { get; set; }
	public int GuildshareParams { get; set; }

	public HouseInformationsForGuild() {}


	public HouseInformationsForGuild InitHouseInformationsForGuild(int InstanceId, bool SecondHand, String OwnerName, short WorldX, short WorldY, double MapId, short SubAreaId, int[] SkillListIds, int GuildshareParams)
	{
		this.InstanceId = InstanceId;
		this.SecondHand = SecondHand;
		this.OwnerName = OwnerName;
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		this.MapId = MapId;
		this.SubAreaId = SubAreaId;
		this.SkillListIds = SkillListIds;
		this.GuildshareParams = GuildshareParams;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteInt(this.InstanceId);
		writer.WriteBoolean(this.SecondHand);
		writer.WriteUTF(this.OwnerName);
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
		writer.WriteDouble(this.MapId);
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteShort(this.SkillListIds.Length);
		foreach (int item in this.SkillListIds)
		{
			writer.WriteInt(item);
		}
		writer.WriteVarInt(this.GuildshareParams);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.InstanceId = reader.ReadInt();
		this.SecondHand = reader.ReadBoolean();
		this.OwnerName = reader.ReadUTF();
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
		this.MapId = reader.ReadDouble();
		this.SubAreaId = reader.ReadVarShort();
		int SkillListIdsLen = reader.ReadShort();
		SkillListIds = new int[SkillListIdsLen];
		for (int i = 0; i < SkillListIdsLen; i++)
		{
			this.SkillListIds[i] = reader.ReadInt();
		}
		this.GuildshareParams = reader.ReadVarInt();
	}
}
}
