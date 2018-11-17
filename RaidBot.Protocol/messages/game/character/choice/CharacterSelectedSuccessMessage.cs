using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterSelectedSuccessMessage : NetworkMessage
{

	public const uint Id = 153;
	public override uint MessageId { get { return Id; } }

	public CharacterBaseInformations Infos { get; set; }
	public bool IsCollectingStats { get; set; }

	public CharacterSelectedSuccessMessage() {}


	public CharacterSelectedSuccessMessage InitCharacterSelectedSuccessMessage(CharacterBaseInformations Infos, bool IsCollectingStats)
	{
		this.Infos = Infos;
		this.IsCollectingStats = IsCollectingStats;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Infos.Serialize(writer);
		writer.WriteBoolean(this.IsCollectingStats);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Infos = new CharacterBaseInformations();
		this.Infos.Deserialize(reader);
		this.IsCollectingStats = reader.ReadBoolean();
	}
}
}
