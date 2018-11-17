using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightTeamMemberTaxCollectorInformations : FightTeamMemberInformations
{

	public const uint Id = 177;
	public override uint MessageId { get { return Id; } }

	public short FirstNameId { get; set; }
	public short LastNameId { get; set; }
	public byte Level { get; set; }
	public int GuildId { get; set; }
	public double Uid { get; set; }

	public FightTeamMemberTaxCollectorInformations() {}


	public FightTeamMemberTaxCollectorInformations InitFightTeamMemberTaxCollectorInformations(short FirstNameId, short LastNameId, byte Level, int GuildId, double Uid)
	{
		this.FirstNameId = FirstNameId;
		this.LastNameId = LastNameId;
		this.Level = Level;
		this.GuildId = GuildId;
		this.Uid = Uid;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.FirstNameId);
		writer.WriteVarShort(this.LastNameId);
		writer.WriteByte(this.Level);
		writer.WriteVarInt(this.GuildId);
		writer.WriteDouble(this.Uid);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.FirstNameId = reader.ReadVarShort();
		this.LastNameId = reader.ReadVarShort();
		this.Level = reader.ReadByte();
		this.GuildId = reader.ReadVarInt();
		this.Uid = reader.ReadDouble();
	}
}
}
