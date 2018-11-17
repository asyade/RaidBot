using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterBuildPreset : PresetsContainerPreset
{

	public const uint Id = 534;
	public override uint MessageId { get { return Id; } }

	public short IconId { get; set; }
	public String Name { get; set; }

	public CharacterBuildPreset() {}


	public CharacterBuildPreset InitCharacterBuildPreset(short IconId, String Name)
	{
		this.IconId = IconId;
		this.Name = Name;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.IconId);
		writer.WriteUTF(this.Name);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.IconId = reader.ReadShort();
		this.Name = reader.ReadUTF();
	}
}
}
