using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PresetSaveRequestMessage : NetworkMessage
{

	public const uint Id = 6761;
	public override uint MessageId { get { return Id; } }

	public short PresetId { get; set; }
	public byte SymbolId { get; set; }
	public bool UpdateData { get; set; }

	public PresetSaveRequestMessage() {}


	public PresetSaveRequestMessage InitPresetSaveRequestMessage(short PresetId, byte SymbolId, bool UpdateData)
	{
		this.PresetId = PresetId;
		this.SymbolId = SymbolId;
		this.UpdateData = UpdateData;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.PresetId);
		writer.WriteByte(this.SymbolId);
		writer.WriteBoolean(this.UpdateData);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PresetId = reader.ReadShort();
		this.SymbolId = reader.ReadByte();
		this.UpdateData = reader.ReadBoolean();
	}
}
}
