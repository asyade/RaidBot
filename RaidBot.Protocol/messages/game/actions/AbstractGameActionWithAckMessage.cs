using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AbstractGameActionWithAckMessage : AbstractGameActionMessage
{

	public const uint Id = 1001;
	public override uint MessageId { get { return Id; } }

	public short WaitAckId { get; set; }

	public AbstractGameActionWithAckMessage() {}


	public AbstractGameActionWithAckMessage InitAbstractGameActionWithAckMessage(short WaitAckId)
	{
		this.WaitAckId = WaitAckId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.WaitAckId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.WaitAckId = reader.ReadShort();
	}
}
}
