using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionMark : NetworkType
{

	public const uint Id = 351;
	public override uint MessageId { get { return Id; } }

	public double MarkAuthorId { get; set; }
	public byte MarkTeamId { get; set; }
	public int MarkSpellId { get; set; }
	public short MarkSpellLevel { get; set; }
	public short MarkId { get; set; }
	public byte MarkType { get; set; }
	public short MarkimpactCell { get; set; }
	public GameActionMarkedCell[] Cells { get; set; }
	public bool Active { get; set; }

	public GameActionMark() {}


	public GameActionMark InitGameActionMark(double MarkAuthorId, byte MarkTeamId, int MarkSpellId, short MarkSpellLevel, short MarkId, byte MarkType, short MarkimpactCell, GameActionMarkedCell[] Cells, bool Active)
	{
		this.MarkAuthorId = MarkAuthorId;
		this.MarkTeamId = MarkTeamId;
		this.MarkSpellId = MarkSpellId;
		this.MarkSpellLevel = MarkSpellLevel;
		this.MarkId = MarkId;
		this.MarkType = MarkType;
		this.MarkimpactCell = MarkimpactCell;
		this.Cells = Cells;
		this.Active = Active;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.MarkAuthorId);
		writer.WriteByte(this.MarkTeamId);
		writer.WriteInt(this.MarkSpellId);
		writer.WriteShort(this.MarkSpellLevel);
		writer.WriteShort(this.MarkId);
		writer.WriteByte(this.MarkType);
		writer.WriteShort(this.MarkimpactCell);
		writer.WriteShort(this.Cells.Length);
		foreach (GameActionMarkedCell item in this.Cells)
		{
			item.Serialize(writer);
		}
		writer.WriteBoolean(this.Active);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MarkAuthorId = reader.ReadDouble();
		this.MarkTeamId = reader.ReadByte();
		this.MarkSpellId = reader.ReadInt();
		this.MarkSpellLevel = reader.ReadShort();
		this.MarkId = reader.ReadShort();
		this.MarkType = reader.ReadByte();
		this.MarkimpactCell = reader.ReadShort();
		int CellsLen = reader.ReadShort();
		Cells = new GameActionMarkedCell[CellsLen];
		for (int i = 0; i < CellsLen; i++)
		{
			this.Cells[i] = new GameActionMarkedCell();
			this.Cells[i].Deserialize(reader);
		}
		this.Active = reader.ReadBoolean();
	}
}
}
