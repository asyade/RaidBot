using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyInvitationMemberInformations : CharacterBaseInformations
{

	public const uint Id = 376;
	public override uint MessageId { get { return Id; } }

	public short WorldX { get; set; }
	public short WorldY { get; set; }
	public double MapId { get; set; }
	public short SubAreaId { get; set; }
	public PartyEntityBaseInformation[] Entities { get; set; }

	public PartyInvitationMemberInformations() {}


	public PartyInvitationMemberInformations InitPartyInvitationMemberInformations(short WorldX, short WorldY, double MapId, short SubAreaId, PartyEntityBaseInformation[] Entities)
	{
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
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
		writer.WriteDouble(this.MapId);
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteShort(this.Entities.Length);
		foreach (PartyEntityBaseInformation item in this.Entities)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
		this.MapId = reader.ReadDouble();
		this.SubAreaId = reader.ReadVarShort();
		int EntitiesLen = reader.ReadShort();
		Entities = new PartyEntityBaseInformation[EntitiesLen];
		for (int i = 0; i < EntitiesLen; i++)
		{
			this.Entities[i] = new PartyEntityBaseInformation();
			this.Entities[i].Deserialize(reader);
		}
	}
}
}
