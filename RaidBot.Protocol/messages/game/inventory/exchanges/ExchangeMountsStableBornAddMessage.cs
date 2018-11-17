using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeMountsStableBornAddMessage : ExchangeMountsStableAddMessage
{

	public const uint Id = 6557;
	public override uint MessageId { get { return Id; } }


	public ExchangeMountsStableBornAddMessage() {}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
	}
}
}
