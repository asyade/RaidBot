using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TreasureHuntLegendaryRequestMessage : NetworkMessage
{

	public const uint Id = 6499;
	public override uint MessageId { get { return Id; } }

	public short LegendaryId { get; set; }

	public TreasureHuntLegendaryRequestMessage() {}


	public TreasureHuntLegendaryRequestMessage InitTreasureHuntLegendaryRequestMessage(short LegendaryId)
	{
		this.LegendaryId = LegendaryId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.LegendaryId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.LegendaryId = reader.ReadVarShort();
	}
}
}
