using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ReloginTokenRequestMessage : NetworkMessage
{

	public const uint Id = 6540;
	public override uint MessageId { get { return Id; } }


	public ReloginTokenRequestMessage() {}

	public override void Serialize(ICustomDataWriter writer)
	{
	}

	public override void Deserialize(ICustomDataReader reader)
	{
	}
}
}
