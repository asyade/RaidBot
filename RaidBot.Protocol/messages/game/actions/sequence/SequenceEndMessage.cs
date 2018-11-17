using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SequenceEndMessage : NetworkMessage
{

	public const uint Id = 956;
	public override uint MessageId { get { return Id; } }

	public short ActionId { get; set; }
	public double AuthorId { get; set; }
	public byte SequenceType { get; set; }

	public SequenceEndMessage() {}


	public SequenceEndMessage InitSequenceEndMessage(short ActionId, double AuthorId, byte SequenceType)
	{
		this.ActionId = ActionId;
		this.AuthorId = AuthorId;
		this.SequenceType = SequenceType;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ActionId);
		writer.WriteDouble(this.AuthorId);
		writer.WriteByte(this.SequenceType);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ActionId = reader.ReadVarShort();
		this.AuthorId = reader.ReadDouble();
		this.SequenceType = reader.ReadByte();
	}
}
}
