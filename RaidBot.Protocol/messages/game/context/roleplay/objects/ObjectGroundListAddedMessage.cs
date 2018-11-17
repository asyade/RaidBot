using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectGroundListAddedMessage : NetworkMessage
{

	public const uint Id = 5925;
	public override uint MessageId { get { return Id; } }

	public short[] Cells { get; set; }
	public short[] ReferenceIds { get; set; }

	public ObjectGroundListAddedMessage() {}


	public ObjectGroundListAddedMessage InitObjectGroundListAddedMessage(short[] Cells, short[] ReferenceIds)
	{
		this.Cells = Cells;
		this.ReferenceIds = ReferenceIds;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Cells.Length);
		foreach (short item in this.Cells)
		{
			writer.WriteVarShort(item);
		}
		writer.WriteShort(this.ReferenceIds.Length);
		foreach (short item in this.ReferenceIds)
		{
			writer.WriteVarShort(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int CellsLen = reader.ReadShort();
		Cells = new short[CellsLen];
		for (int i = 0; i < CellsLen; i++)
		{
			this.Cells[i] = reader.ReadVarShort();
		}
		int ReferenceIdsLen = reader.ReadShort();
		ReferenceIds = new short[ReferenceIdsLen];
		for (int i = 0; i < ReferenceIdsLen; i++)
		{
			this.ReferenceIds[i] = reader.ReadVarShort();
		}
	}
}
}
