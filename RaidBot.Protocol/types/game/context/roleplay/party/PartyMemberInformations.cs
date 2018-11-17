using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyMemberInformations : CharacterBaseInformations
{

	public const uint Id = 90;
	public override uint MessageId { get { return Id; } }

	public int LifePoints { get; set; }
	public int MaxLifePoints { get; set; }
	public short Prospecting { get; set; }
	public byte RegenRate { get; set; }
	public short Initiative { get; set; }
	public byte AlignmentSide { get; set; }
	public short WorldX { get; set; }
	public short WorldY { get; set; }
	public double MapId { get; set; }
	public short SubAreaId { get; set; }
	public PartyEntityBaseInformation[] Entities { get; set; }

	public PartyMemberInformations() {}


	public PartyMemberInformations InitPartyMemberInformations(int LifePoints, int MaxLifePoints, short Prospecting, byte RegenRate, short Initiative, byte AlignmentSide, short WorldX, short WorldY, double MapId, short SubAreaId, PartyEntityBaseInformation[] Entities)
	{
		this.LifePoints = LifePoints;
		this.MaxLifePoints = MaxLifePoints;
		this.Prospecting = Prospecting;
		this.RegenRate = RegenRate;
		this.Initiative = Initiative;
		this.AlignmentSide = AlignmentSide;
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		this.MapId = MapId;
		this.SubAreaId = SubAreaId;
		this.Entities = Entities;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.LifePoints);
		writer.WriteVarInt(this.MaxLifePoints);
		writer.WriteVarShort(this.Prospecting);
		writer.WriteByte(this.RegenRate);
		writer.WriteVarShort(this.Initiative);
		writer.WriteByte(this.AlignmentSide);
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
		writer.WriteDouble(this.MapId);
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteShort(this.Entities.Length);
		foreach (PartyEntityBaseInformation item in this.Entities)
		{
			writer.WriteShort(item.MessageId);
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.LifePoints = reader.ReadVarInt();
		this.MaxLifePoints = reader.ReadVarInt();
		this.Prospecting = reader.ReadVarShort();
		this.RegenRate = reader.ReadByte();
		this.Initiative = reader.ReadVarShort();
		this.AlignmentSide = reader.ReadByte();
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
		this.MapId = reader.ReadDouble();
		this.SubAreaId = reader.ReadVarShort();
		int EntitiesLen = reader.ReadShort();
		Entities = new PartyEntityBaseInformation[EntitiesLen];
		for (int i = 0; i < EntitiesLen; i++)
		{
			this.Entities[i] = ProtocolTypeManager.GetInstance<PartyEntityBaseInformation>(reader.ReadShort());
			this.Entities[i].Deserialize(reader);
		}
	}
}
}
