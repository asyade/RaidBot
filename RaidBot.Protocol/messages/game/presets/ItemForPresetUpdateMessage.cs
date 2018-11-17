using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ItemForPresetUpdateMessage : NetworkMessage
{

	public const uint Id = 6760;
	public override uint MessageId { get { return Id; } }

	public short PresetId { get; set; }
	public ItemForPreset PresetItem { get; set; }

	public ItemForPresetUpdateMessage() {}


	public ItemForPresetUpdateMessage InitItemForPresetUpdateMessage(short PresetId, ItemForPreset PresetItem)
	{
		this.PresetId = PresetId;
		this.PresetItem = PresetItem;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.PresetId);
		this.PresetItem.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PresetId = reader.ReadShort();
		this.PresetItem = new ItemForPreset();
		this.PresetItem.Deserialize(reader);
	}
}
}
