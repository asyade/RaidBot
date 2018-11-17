using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DungeonPartyFinderRoomContentMessage : NetworkMessage
{

	public const uint Id = 6247;
	public override uint MessageId { get { return Id; } }

	public short DungeonId { get; set; }
	public DungeonPartyFinderPlayer[] Players { get; set; }

	public DungeonPartyFinderRoomContentMessage() {}


	public DungeonPartyFinderRoomContentMessage InitDungeonPartyFinderRoomContentMessage(short DungeonId, DungeonPartyFinderPlayer[] Players)
	{
		this.DungeonId = DungeonId;
		this.Players = Players;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.DungeonId);
		writer.WriteShort(this.Players.Length);
		foreach (DungeonPartyFinderPlayer item in this.Players)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DungeonId = reader.ReadVarShort();
		int PlayersLen = reader.ReadShort();
		Players = new DungeonPartyFinderPlayer[PlayersLen];
		for (int i = 0; i < PlayersLen; i++)
		{
			this.Players[i] = new DungeonPartyFinderPlayer();
			this.Players[i].Deserialize(reader);
		}
	}
}
}
