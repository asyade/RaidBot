using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyLeaveRequestMessage : AbstractPartyMessage
{

	public const uint Id = 5593;
	public override uint MessageId { get { return Id; } }


	public PartyLeaveRequestMessage() {}

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
