using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterCapabilitiesMessage : NetworkMessage
{

	public const uint Id = 6339;
	public override uint MessageId { get { return Id; } }

	public int GuildEmblemSymbolCategories { get; set; }

	public CharacterCapabilitiesMessage() {}


	public CharacterCapabilitiesMessage InitCharacterCapabilitiesMessage(int GuildEmblemSymbolCategories)
	{
		this.GuildEmblemSymbolCategories = GuildEmblemSymbolCategories;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.GuildEmblemSymbolCategories);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.GuildEmblemSymbolCategories = reader.ReadVarInt();
	}
}
}
