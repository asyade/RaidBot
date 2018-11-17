using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ShortcutEntitiesPreset : Shortcut
{

	public const uint Id = 544;
	public override uint MessageId { get { return Id; } }

	public short PresetId { get; set; }

	public ShortcutEntitiesPreset() {}


	public ShortcutEntitiesPreset InitShortcutEntitiesPreset(short PresetId)
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
