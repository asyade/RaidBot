using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeReadyMessage : NetworkMessage
{

	public const uint Id = 5511;
	public override uint MessageId { get { return Id; } }

	public bool Ready { get; set; }
	public short Step { get; set; }

	public ExchangeReadyMessage() {}


	public ExchangeReadyMessage InitExchangeReadyMessage(bool Ready, short Step)
	{
		this.Ready = Ready;
		this.Step = Step;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Ready);
		writer.WriteVarShort(this.Step);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Ready = reader.ReadBoolean();
		this.Step = reader.ReadVarShort();
	}
}
}
