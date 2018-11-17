using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class EntityDispositionInformations : NetworkType
{

	public const uint Id = 60;
	public override uint MessageId { get { return Id; } }

	public short CellId { get; set; }
	public byte Direction { get; set; }

	public EntityDispositionInformations() {}


	public EntityDispositionInformations InitEntityDispositionInformations(short CellId, byte Direction)
	{
		this.CellId = CellId;
		this.Direction = Direction;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.CellId);
		writer.WriteByte(this.Direction);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CellId = reader.ReadShort();
		this.Direction = reader.ReadByte();
	}
}
}
