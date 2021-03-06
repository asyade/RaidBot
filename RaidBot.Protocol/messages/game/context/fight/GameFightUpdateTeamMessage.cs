using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightUpdateTeamMessage : NetworkMessage
{

	public const uint Id = 5572;
	public override uint MessageId { get { return Id; } }

	public short FightId { get; set; }
	public FightTeamInformations Team { get; set; }

	public GameFightUpdateTeamMessage() {}


	public GameFightUpdateTeamMessage InitGameFightUpdateTeamMessage(short FightId, FightTeamInformations Team)
	{
		this.FightId = FightId;
		this.Team = Team;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.FightId);
		this.Team.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FightId = reader.ReadVarShort();
		this.Team = new FightTeamInformations();
		this.Team.Deserialize(reader);
	}
}
}
