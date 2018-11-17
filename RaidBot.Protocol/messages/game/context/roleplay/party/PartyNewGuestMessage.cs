using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyNewGuestMessage : AbstractPartyEventMessage
{

	public const uint Id = 6260;
	public override uint MessageId { get { return Id; } }

	public PartyGuestInformations Guest { get; set; }

	public PartyNewGuestMessage() {}


	public PartyNewGuestMessage InitPartyNewGuestMessage(PartyGuestInformations Guest)
	{
		this.Guest = Guest;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.Guest.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Guest = new PartyGuestInformations();
		this.Guest.Deserialize(reader);
	}
}
}
