using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PaddockInformationsForSell : NetworkType
{

	public const uint Id = 222;
	public override uint MessageId { get { return Id; } }

	public String GuildOwner { get; set; }
	public short WorldX { get; set; }
	public short WorldY { get; set; }
	public short SubAreaId { get; set; }
	public byte NbMount { get; set; }
	public byte NbObject { get; set; }
	public long Price { get; set; }

	public PaddockInformationsForSell() {}


	public PaddockInformationsForSell InitPaddockInformationsForSell(String GuildOwner, short WorldX, short WorldY, short SubAreaId, byte NbMount, byte NbObject, long Price)
	{
		this.GuildOwner = GuildOwner;
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		this.SubAreaId = SubAreaId;
		this.NbMount = NbMount;
		this.NbObject = NbObject;
		this.Price = Price;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.GuildOwner);
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteByte(this.NbMount);
		writer.WriteByte(this.NbObject);
		writer.WriteVarLong(this.Price);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.GuildOwner = reader.ReadUTF();
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
		this.SubAreaId = reader.ReadVarShort();
		this.NbMount = reader.ReadByte();
		this.NbObject = reader.ReadByte();
		this.Price = reader.ReadVarLong();
	}
}
}
