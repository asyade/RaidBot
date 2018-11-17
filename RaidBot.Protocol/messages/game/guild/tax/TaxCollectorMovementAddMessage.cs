using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TaxCollectorMovementAddMessage : NetworkMessage
{

	public const uint Id = 5917;
	public override uint MessageId { get { return Id; } }


	public TaxCollectorMovementAddMessage() {}

	public override void Serialize(ICustomDataWriter writer)
	{
	}

	public override void Deserialize(ICustomDataReader reader)
	{
	}
}
}
