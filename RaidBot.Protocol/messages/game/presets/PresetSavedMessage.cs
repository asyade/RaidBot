using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PresetSavedMessage : NetworkMessage
{

	public const uint Id = 6763;
	public override uint MessageId { get { return Id; } }

	public short PresetId { get; set; }

	public PresetSavedMessage() {}


	public PresetSavedMessage InitPresetSavedMessage(short PresetId)
	{
		this.PresetId = PresetId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.PresetId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PresetId = reader.ReadShort();
	}
}
}
