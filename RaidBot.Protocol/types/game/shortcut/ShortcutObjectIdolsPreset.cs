using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ShortcutObjectIdolsPreset : ShortcutObject
{

	public const uint Id = 492;
	public override uint MessageId { get { return Id; } }

	public short PresetId { get; set; }

	public ShortcutObjectIdolsPreset() {}


	public ShortcutObjectIdolsPreset InitShortcutObjectIdolsPreset(short PresetId)
	{
		this.PresetId = PresetId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.PresetId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.PresetId = reader.ReadShort();
	}
}
}
