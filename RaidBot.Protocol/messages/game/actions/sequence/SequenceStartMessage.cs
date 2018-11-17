using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SequenceStartMessage : NetworkMessage
{

	public const uint Id = 955;
	public override uint MessageId { get { return Id; } }

	public byte SequenceType { get; set; }
	public double AuthorId { get; set; }

	public SequenceStartMessage() {}


	public SequenceStartMessage InitSequenceStartMessage(byte SequenceType, double AuthorId)
	{
		this.SequenceType = SequenceType;
		this.AuthorId = AuthorId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.SequenceType);
		writer.WriteDouble(this.AuthorId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SequenceType = reader.ReadByte();
		this.AuthorId = reader.ReadDouble();
	}
}
}
