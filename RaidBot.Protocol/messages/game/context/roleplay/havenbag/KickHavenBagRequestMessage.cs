using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class KickHavenBagRequestMessage : NetworkMessage
{

	public const uint Id = 6652;
	public override uint MessageId { get { return Id; } }

	public long GuestId { get; set; }

	public KickHavenBagRequestMessage() {}


	public KickHavenBagRequestMessage InitKickHavenBagRequestMessage(long GuestId)
	{
		this.GuestId = GuestId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.GuestId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.GuestId = reader.ReadVarLong();
	}
}
}
