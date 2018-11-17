using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeStoppedMessage : NetworkMessage
{

	public const uint Id = 6589;
	public override uint MessageId { get { return Id; } }

	public long Id_ { get; set; }

	public ExchangeStoppedMessage() {}


	public ExchangeStoppedMessage InitExchangeStoppedMessage(long Id_)
	{
		this.Id_ = Id_;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.Id_);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadVarLong();
	}
}
}
