using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyEntityMemberInformation : PartyEntityBaseInformation
{

	public const uint Id = 550;
	public override uint MessageId { get { return Id; } }

	public short Initiative { get; set; }
	public int LifePoints { get; set; }
	public int MaxLifePoints { get; set; }
	public short Prospecting { get; set; }
	public byte RegenRate { get; set; }

	public PartyEntityMemberInformation() {}


	public PartyEntityMemberInformation InitPartyEntityMemberInformation(short Initiative, int LifePoints, int MaxLifePoints, short Prospecting, byte RegenRate)
	{
		this.Initiative = Initiative;
		this.LifePoints = LifePoints;
		this.MaxLifePoints = MaxLifePoints;
		this.Prospecting = Prospecting;
		this.RegenRate = RegenRate;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.Initiative);
		writer.WriteVarInt(this.LifePoints);
		writer.WriteVarInt(this.MaxLifePoints);
		writer.WriteVarShort(this.Prospecting);
		writer.WriteByte(this.RegenRate);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Initiative = reader.ReadVarShort();
		this.LifePoints = reader.ReadVarInt();
		this.MaxLifePoints = reader.ReadVarInt();
		this.Prospecting = reader.ReadVarShort();
		this.RegenRate = reader.ReadByte();
	}
}
}
