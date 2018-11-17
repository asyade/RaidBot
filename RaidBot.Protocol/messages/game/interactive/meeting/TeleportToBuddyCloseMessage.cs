using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TeleportToBuddyCloseMessage : NetworkMessage
{

	public const uint Id = 6303;
	public override uint MessageId { get { return Id; } }

	public short DungeonId { get; set; }
	public long BuddyId { get; set; }

	public TeleportToBuddyCloseMessage() {}


	public TeleportToBuddyCloseMessage InitTeleportToBuddyCloseMessage(short DungeonId, long BuddyId)
	{
		this.DungeonId = DungeonId;
		this.BuddyId = BuddyId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.DungeonId);
		writer.WriteVarLong(this.BuddyId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DungeonId = reader.ReadVarShort();
		this.BuddyId = reader.ReadVarLong();
	}
}
}
