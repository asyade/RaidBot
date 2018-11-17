using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterBasicMinimalInformations : AbstractCharacterInformation
{

	public const uint Id = 503;
	public override uint MessageId { get { return Id; } }

	public String Name { get; set; }

	public CharacterBasicMinimalInformations() {}


	public CharacterBasicMinimalInformations InitCharacterBasicMinimalInformations(String Name)
	{
		this.Name = Name;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.Name);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Name = reader.ReadUTF();
	}
}
}
