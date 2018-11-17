using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TeleportToBuddyOfferMessage : NetworkMessage
{

	public const uint Id = 6287;
	public override uint MessageId { get { return Id; } }

	public short DungeonId { get; set; }
	public long BuddyId { get; set; }
	public int TimeLeft { get; set; }

	public TeleportToBuddyOfferMessage() {}


	public TeleportToBuddyOfferMessage InitTeleportToBuddyOfferMessage(short DungeonId, long BuddyId, int TimeLeft)
	{
		this.DungeonId = DungeonId;
		this.BuddyId = BuddyId;
		this.TimeLeft = TimeLeft;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.DungeonId);
		writer.WriteVarLong(this.BuddyId);
		writer.WriteVarInt(this.TimeLeft);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DungeonId = reader.ReadVarShort();
		this.BuddyId = reader.ReadVarLong();
		this.TimeLeft = reader.ReadVarInt();
	}
}
}
