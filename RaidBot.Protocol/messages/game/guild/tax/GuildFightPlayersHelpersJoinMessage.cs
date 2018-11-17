using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildFightPlayersHelpersJoinMessage : NetworkMessage
{

	public const uint Id = 5720;
	public override uint MessageId { get { return Id; } }

	public double FightId { get; set; }
	public CharacterMinimalPlusLookInformations PlayerInfo { get; set; }

	public GuildFightPlayersHelpersJoinMessage() {}


	public GuildFightPlayersHelpersJoinMessage InitGuildFightPlayersHelpersJoinMessage(double FightId, CharacterMinimalPlusLookInformations PlayerInfo)
	{
		this.FightId = FightId;
		this.PlayerInfo = PlayerInfo;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.FightId);
		this.PlayerInfo.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FightId = reader.ReadDouble();
		this.PlayerInfo = new CharacterMinimalPlusLookInformations();
		this.PlayerInfo.Deserialize(reader);
	}
}
}
