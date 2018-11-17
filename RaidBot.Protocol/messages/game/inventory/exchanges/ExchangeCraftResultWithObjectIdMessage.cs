using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeCraftResultWithObjectIdMessage : ExchangeCraftResultMessage
{

	public const uint Id = 6000;
	public override uint MessageId { get { return Id; } }

	public short ObjectGenericId { get; set; }

	public ExchangeCraftResultWithObjectIdMessage() {}


	public ExchangeCraftResultWithObjectIdMessage InitExchangeCraftResultWithObjectIdMessage(short ObjectGenericId)
	{
		this.ObjectGenericId = ObjectGenericId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.ObjectGenericId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.ObjectGenericId = reader.ReadVarShort();
	}
}
}
