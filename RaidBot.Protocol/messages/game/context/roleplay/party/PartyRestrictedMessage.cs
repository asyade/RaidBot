using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyRestrictedMessage : AbstractPartyMessage
{

	public const uint Id = 6175;
	public override uint MessageId { get { return Id; } }

	public bool Restricted { get; set; }

	public PartyRestrictedMessage() {}


	public PartyRestrictedMessage InitPartyRestrictedMessage(bool Restricted)
	{
		this.Restricted = Restricted;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteBoolean(this.Restricted);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Restricted = reader.ReadBoolean();
	}
}
}
