using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class NamedPartyTeamWithOutcome : NetworkType
{

	public const uint Id = 470;
	public override uint MessageId { get { return Id; } }

	public NamedPartyTeam Team { get; set; }
	public short Outcome { get; set; }

	public NamedPartyTeamWithOutcome() {}


	public NamedPartyTeamWithOutcome InitNamedPartyTeamWithOutcome(NamedPartyTeam Team, short Outcome)
	{
		this.Team = Team;
		this.Outcome = Outcome;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Team.Serialize(writer);
		writer.WriteVarShort(this.Outcome);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Team = new NamedPartyTeam();
		this.Team.Deserialize(reader);
		this.Outcome = reader.ReadVarShort();
	}
}
}
