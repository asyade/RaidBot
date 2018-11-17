using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterMinimalGuildInformations : CharacterMinimalPlusLookInformations
{

	public const uint Id = 445;
	public override uint MessageId { get { return Id; } }

	public BasicGuildInformations Guild { get; set; }

	public CharacterMinimalGuildInformations() {}


	public CharacterMinimalGuildInformations InitCharacterMinimalGuildInformations(BasicGuildInformations Guild)
	{
		this.Guild = Guild;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.Guild.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Guild = new BasicGuildInformations();
		this.Guild.Deserialize(reader);
	}
}
}
