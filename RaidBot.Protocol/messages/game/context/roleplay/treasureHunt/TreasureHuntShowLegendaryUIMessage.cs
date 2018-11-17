using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TreasureHuntShowLegendaryUIMessage : NetworkMessage
{

	public const uint Id = 6498;
	public override uint MessageId { get { return Id; } }

	public short[] AvailableLegendaryIds { get; set; }

	public TreasureHuntShowLegendaryUIMessage() {}


	public TreasureHuntShowLegendaryUIMessage InitTreasureHuntShowLegendaryUIMessage(short[] AvailableLegendaryIds)
	{
		this.AvailableLegendaryIds = AvailableLegendaryIds;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.AvailableLegendaryIds.Length);
		foreach (short item in this.AvailableLegendaryIds)
		{
			writer.WriteVarShort(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int AvailableLegendaryIdsLen = reader.ReadShort();
		AvailableLegendaryIds = new short[AvailableLegendaryIdsLen];
		for (int i = 0; i < AvailableLegendaryIdsLen; i++)
		{
			this.AvailableLegendaryIds[i] = reader.ReadVarShort();
		}
	}
}
}
