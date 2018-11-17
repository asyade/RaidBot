using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightResultTaxCollectorListEntry : FightResultFighterListEntry
{

	public const uint Id = 84;
	public override uint MessageId { get { return Id; } }

	public byte Level { get; set; }
	public BasicGuildInformations GuildInfo { get; set; }
	public int ExperienceForGuild { get; set; }

	public FightResultTaxCollectorListEntry() {}


	public FightResultTaxCollectorListEntry InitFightResultTaxCollectorListEntry(byte Level, BasicGuildInformations GuildInfo, int ExperienceForGuild)
	{
		this.Level = Level;
		this.GuildInfo = GuildInfo;
		this.ExperienceForGuild = ExperienceForGuild;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.Level);
		this.GuildInfo.Serialize(writer);
		writer.WriteInt(this.ExperienceForGuild);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Level = reader.ReadByte();
		this.GuildInfo = new BasicGuildInformations();
		this.GuildInfo.Deserialize(reader);
		this.ExperienceForGuild = reader.ReadInt();
	}
}
}
