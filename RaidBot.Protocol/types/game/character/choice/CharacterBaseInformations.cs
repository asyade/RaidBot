using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterBaseInformations : CharacterMinimalPlusLookInformations
{

	public const uint Id = 45;
	public override uint MessageId { get { return Id; } }

	public bool Sex { get; set; }

	public CharacterBaseInformations() {}


	public CharacterBaseInformations InitCharacterBaseInformations(bool Sex)
	{
		this.Sex = Sex;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteBoolean(this.Sex);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Sex = reader.ReadBoolean();
	}
}
}
