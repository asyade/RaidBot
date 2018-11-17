using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DungeonPartyFinderRegisterSuccessMessage : NetworkMessage
{

	public const uint Id = 6241;
	public override uint MessageId { get { return Id; } }

	public short[] DungeonIds { get; set; }

	public DungeonPartyFinderRegisterSuccessMessage() {}


	public DungeonPartyFinderRegisterSuccessMessage InitDungeonPartyFinderRegisterSuccessMessage(short[] DungeonIds)
	{
		this.DungeonIds = DungeonIds;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.DungeonIds.Length);
		foreach (short item in this.DungeonIds)
		{
			writer.WriteVarShort(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int DungeonIdsLen = reader.ReadShort();
		DungeonIds = new short[DungeonIdsLen];
		for (int i = 0; i < DungeonIdsLen; i++)
		{
			this.DungeonIds[i] = reader.ReadVarShort();
		}
	}
}
}
