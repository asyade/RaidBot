using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterToRemodelInformations : CharacterRemodelingInformation
{

	public const uint Id = 477;
	public override uint MessageId { get { return Id; } }

	public byte PossibleChangeMask { get; set; }
	public byte MandatoryChangeMask { get; set; }

	public CharacterToRemodelInformations() {}


	public CharacterToRemodelInformations InitCharacterToRemodelInformations(byte PossibleChangeMask, byte MandatoryChangeMask)
	{
		this.PossibleChangeMask = PossibleChangeMask;
		this.MandatoryChangeMask = MandatoryChangeMask;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.PossibleChangeMask);
		writer.WriteByte(this.MandatoryChangeMask);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.PossibleChangeMask = reader.ReadByte();
		this.MandatoryChangeMask = reader.ReadByte();
	}
}
}
