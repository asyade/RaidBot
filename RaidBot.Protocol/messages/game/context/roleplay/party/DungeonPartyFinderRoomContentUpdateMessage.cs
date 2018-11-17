using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DungeonPartyFinderRoomContentUpdateMessage : NetworkMessage
{

	public const uint Id = 6250;
	public override uint MessageId { get { return Id; } }

	public short DungeonId { get; set; }
	public DungeonPartyFinderPlayer[] AddedPlayers { get; set; }
	public long[] RemovedPlayersIds { get; set; }

	public DungeonPartyFinderRoomContentUpdateMessage() {}


	public DungeonPartyFinderRoomContentUpdateMessage InitDungeonPartyFinderRoomContentUpdateMessage(short DungeonId, DungeonPartyFinderPlayer[] AddedPlayers, long[] RemovedPlayersIds)
	{
		this.DungeonId = DungeonId;
		this.AddedPlayers = AddedPlayers;
		this.RemovedPlayersIds = RemovedPlayersIds;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.DungeonId);
		writer.WriteShort(this.AddedPlayers.Length);
		foreach (DungeonPartyFinderPlayer item in this.AddedPlayers)
		{
			item.Serialize(writer);
		}
		writer.WriteShort(this.RemovedPlayersIds.Length);
		foreach (long item in this.RemovedPlayersIds)
		{
			writer.WriteVarLong(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DungeonId = reader.ReadVarShort();
		int AddedPlayersLen = reader.ReadShort();
		AddedPlayers = new DungeonPartyFinderPlayer[AddedPlayersLen];
		for (int i = 0; i < AddedPlayersLen; i++)
		{
			this.AddedPlayers[i] = new DungeonPartyFinderPlayer();
			this.AddedPlayers[i].Deserialize(reader);
		}
		int RemovedPlayersIdsLen = reader.ReadShort();
		RemovedPlayersIds = new long[RemovedPlayersIdsLen];
		for (int i = 0; i < RemovedPlayersIdsLen; i++)
		{
			this.RemovedPlayersIds[i] = reader.ReadVarLong();
		}
	}
}
}
