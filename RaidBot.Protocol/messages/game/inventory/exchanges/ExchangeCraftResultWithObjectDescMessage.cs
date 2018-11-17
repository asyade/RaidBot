using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeCraftResultWithObjectDescMessage : ExchangeCraftResultMessage
{

	public const uint Id = 5999;
	public override uint MessageId { get { return Id; } }

	public ObjectItemNotInContainer ObjectInfo { get; set; }

	public ExchangeCraftResultWithObjectDescMessage() {}


	public ExchangeCraftResultWithObjectDescMessage InitExchangeCraftResultWithObjectDescMessage(ObjectItemNotInContainer ObjectInfo)
	{
		this.ObjectInfo = ObjectInfo;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.ObjectInfo.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.ObjectInfo = new ObjectItemNotInContainer();
		this.ObjectInfo.Deserialize(reader);
	}
}
}
