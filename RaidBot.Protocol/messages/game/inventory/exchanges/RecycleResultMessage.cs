using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class RecycleResultMessage : NetworkMessage
{

	public const uint Id = 6601;
	public override uint MessageId { get { return Id; } }

	public int NuggetsForPrism { get; set; }
	public int NuggetsForPlayer { get; set; }

	public RecycleResultMessage() {}


	public RecycleResultMessage InitRecycleResultMessage(int NuggetsForPrism, int NuggetsForPlayer)
	{
		this.NuggetsForPrism = NuggetsForPrism;
		this.NuggetsForPlayer = NuggetsForPlayer;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.NuggetsForPrism);
		writer.WriteVarInt(this.NuggetsForPlayer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.NuggetsForPrism = reader.ReadVarInt();
		this.NuggetsForPlayer = reader.ReadVarInt();
	}
}
}
