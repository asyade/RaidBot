using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class IdolsPreset : Preset
{

	public const uint Id = 491;
	public override uint MessageId { get { return Id; } }

	public short IconId { get; set; }
	public short[] IdolIds { get; set; }

	public IdolsPreset() {}


	public IdolsPreset InitIdolsPreset(short IconId, short[] IdolIds)
	{
		this.IconId = IconId;
		this.IdolIds = IdolIds;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.IconId);
		writer.WriteShort(this.IdolIds.Length);
		foreach (short item in this.IdolIds)
		{
			writer.WriteVarShort(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.IconId = reader.ReadShort();
		int IdolIdsLen = reader.ReadShort();
		IdolIds = new short[IdolIdsLen];
		for (int i = 0; i < IdolIdsLen; i++)
		{
			this.IdolIds[i] = reader.ReadVarShort();
		}
	}
}
}
