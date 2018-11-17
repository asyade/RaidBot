using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterCharacteristicForPreset : SimpleCharacterCharacteristicForPreset
{

	public const uint Id = 539;
	public override uint MessageId { get { return Id; } }

	public short Stuff { get; set; }

	public CharacterCharacteristicForPreset() {}


	public CharacterCharacteristicForPreset InitCharacterCharacteristicForPreset(short Stuff)
	{
		this.Stuff = Stuff;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.Stuff);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Stuff = reader.ReadVarShort();
	}
}
}
