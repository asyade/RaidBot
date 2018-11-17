using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PresetDeleteResultMessage : NetworkMessage
{

	public const uint Id = 6748;
	public override uint MessageId { get { return Id; } }

	public short PresetId { get; set; }
	public byte Code { get; set; }

	public PresetDeleteResultMessage() {}


	public PresetDeleteResultMessage InitPresetDeleteResultMessage(short PresetId, byte Code)
	{
		this.PresetId = PresetId;
		this.Code = Code;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.PresetId);
		writer.WriteByte(this.Code);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PresetId = reader.ReadShort();
		this.Code = reader.ReadByte();
	}
}
}
