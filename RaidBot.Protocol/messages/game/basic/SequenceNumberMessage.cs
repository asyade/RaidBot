using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SequenceNumberMessage : NetworkMessage
{

	public const uint Id = 6317;
	public override uint MessageId { get { return Id; } }

	public short Number { get; set; }

	public SequenceNumberMessage() {}


	public SequenceNumberMessage InitSequenceNumberMessage(short Number)
	{
		this.Number = Number;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Number);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Number = reader.ReadShort();
	}
}
}
