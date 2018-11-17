using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterNameSuggestionSuccessMessage : NetworkMessage
{

	public const uint Id = 5544;
	public override uint MessageId { get { return Id; } }

	public String Suggestion { get; set; }

	public CharacterNameSuggestionSuccessMessage() {}


	public CharacterNameSuggestionSuccessMessage InitCharacterNameSuggestionSuccessMessage(String Suggestion)
	{
		this.Suggestion = Suggestion;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Suggestion);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Suggestion = reader.ReadUTF();
	}
}
}
