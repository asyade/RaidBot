using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeIsReadyMessage : NetworkMessage
{

	public const uint Id = 5509;
	public override uint MessageId { get { return Id; } }

	public double Id_ { get; set; }
	public bool Ready { get; set; }

	public ExchangeIsReadyMessage() {}


	public ExchangeIsReadyMessage InitExchangeIsReadyMessage(double Id_, bool Ready)
	{
		this.Id_ = Id_;
		this.Ready = Ready;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.Id_);
		writer.WriteBoolean(this.Ready);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadDouble();
		this.Ready = reader.ReadBoolean();
	}
}
}
