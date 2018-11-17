using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterStatsListMessage : NetworkMessage
{

	public const uint Id = 500;
	public override uint MessageId { get { return Id; } }

	public CharacterCharacteristicsInformations Stats { get; set; }

	public CharacterStatsListMessage() {}


	public CharacterStatsListMessage InitCharacterStatsListMessage(CharacterCharacteristicsInformations Stats)
	{
		this.Stats = Stats;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Stats.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Stats = new CharacterCharacteristicsInformations();
		this.Stats.Deserialize(reader);
	}
}
}
