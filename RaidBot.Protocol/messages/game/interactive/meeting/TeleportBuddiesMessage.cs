using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TeleportBuddiesMessage : NetworkMessage
{

	public const uint Id = 6289;
	public override uint MessageId { get { return Id; } }

	public short DungeonId { get; set; }

	public TeleportBuddiesMessage() {}


	public TeleportBuddiesMessage InitTeleportBuddiesMessage(short DungeonId)
	{
		this.DungeonId = DungeonId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.DungeonId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DungeonId = reader.ReadVarShort();
	}
}
}
