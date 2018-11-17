using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectGroundRemovedMultipleMessage : NetworkMessage
{

	public const uint Id = 5944;
	public override uint MessageId { get { return Id; } }

	public short[] Cells { get; set; }

	public ObjectGroundRemovedMultipleMessage() {}


	public ObjectGroundRemovedMultipleMessage InitObjectGroundRemovedMultipleMessage(short[] Cells)
	{
		this.Cells = Cells;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Cells.Length);
		foreach (short item in this.Cells)
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
	}
}
}
