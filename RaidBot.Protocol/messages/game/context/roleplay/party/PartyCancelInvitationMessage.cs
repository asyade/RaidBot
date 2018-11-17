using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyCancelInvitationMessage : AbstractPartyMessage
{

	public const uint Id = 6254;
	public override uint MessageId { get { return Id; } }

	public long GuestId { get; set; }

	public PartyCancelInvitationMessage() {}


	public PartyCancelInvitationMessage InitPartyCancelInvitationMessage(long GuestId)
	{
		this.GuestId = GuestId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.GuestId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.GuestId = reader.ReadVarLong();
	}
}
}
