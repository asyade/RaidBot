using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildEmblem : NetworkType
{

	public const uint Id = 87;
	public override uint MessageId { get { return Id; } }

	public short SymbolShape { get; set; }
	public int SymbolColor { get; set; }
	public byte BackgroundShape { get; set; }
	public int BackgroundColor { get; set; }

	public GuildEmblem() {}


	public GuildEmblem InitGuildEmblem(short SymbolShape, int SymbolColor, byte BackgroundShape, int BackgroundColor)
	{
		this.SymbolShape = SymbolShape;
		this.SymbolColor = SymbolColor;
		this.BackgroundShape = BackgroundShape;
		this.BackgroundColor = BackgroundColor;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SymbolShape);
		writer.WriteInt(this.SymbolColor);
		writer.WriteByte(this.BackgroundShape);
		writer.WriteInt(this.BackgroundColor);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SymbolShape = reader.ReadVarShort();
		this.SymbolColor = reader.ReadInt();
		this.BackgroundShape = reader.ReadByte();
		this.BackgroundColor = reader.ReadInt();
	}
}
}
