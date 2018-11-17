using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyCancelInvitationNotificationMessage : AbstractPartyEventMessage
{

	public const uint Id = 6251;
	public override uint MessageId { get { return Id; } }

	public long CancelerId { get; set; }
	public long GuestId { get; set; }

	public PartyCancelInvitationNotificationMessage() {}


	public PartyCancelInvitationNotificationMessage InitPartyCancelInvitationNotificationMessage(long CancelerId, long GuestId)
	{
		this.CancelerId = CancelerId;
		this.GuestId = GuestId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.CancelerId);
		writer.WriteVarLong(this.GuestId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.CancelerId = reader.ReadVarLong();
		this.GuestId = reader.ReadVarLong();
	}
}
}
