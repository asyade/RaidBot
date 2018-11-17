using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CredentialsAcknowledgementMessage : NetworkMessage
{

	public const uint Id = 6314;
	public override uint MessageId { get { return Id; } }


	public CredentialsAcknowledgementMessage() {}

	public override void Serialize(ICustomDataWriter writer)
	{
	}

	public override void Deserialize(ICustomDataReader reader)
	{
	}
}
}
