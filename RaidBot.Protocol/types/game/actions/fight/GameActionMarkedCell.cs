using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionMarkedCell : NetworkType
{

	public const uint Id = 85;
	public override uint MessageId { get { return Id; } }

	public short CellId { get; set; }
	public byte ZoneSize { get; set; }
	public int CellColor { get; set; }
	public byte CellsType { get; set; }

	public GameActionMarkedCell() {}


	public GameActionMarkedCell InitGameActionMarkedCell(short CellId, byte ZoneSize, int CellColor, byte CellsType)
	{
		this.CellId = CellId;
		this.ZoneSize = ZoneSize;
		this.CellColor = CellColor;
		this.CellsType = CellsType;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.CellId);
		writer.WriteByte(this.ZoneSize);
		writer.WriteInt(this.CellColor);
		writer.WriteByte(this.CellsType);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CellId = reader.ReadVarShort();
		this.ZoneSize = reader.ReadByte();
		this.CellColor = reader.ReadInt();
		this.CellsType = reader.ReadByte();
	}
}
}
