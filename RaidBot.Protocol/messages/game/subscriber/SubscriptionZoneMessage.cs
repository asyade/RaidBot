using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SubscriptionZoneMessage : NetworkMessage
{

	public const uint Id = 5573;
	public override uint MessageId { get { return Id; } }

	public bool Active { get; set; }

	public SubscriptionZoneMessage() {}


	public SubscriptionZoneMessage InitSubscriptionZoneMessage(bool Active)
	{
		this.Active = Active;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Active);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Active = reader.ReadBoolean();
	}
}
}
