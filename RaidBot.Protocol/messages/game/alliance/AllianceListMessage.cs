using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AllianceListMessage : NetworkMessage
{

	public const uint Id = 6408;
	public override uint MessageId { get { return Id; } }

	public AllianceFactSheetInformations[] Alliances { get; set; }

	public AllianceListMessage() {}


	public AllianceListMessage InitAllianceListMessage(AllianceFactSheetInformations[] Alliances)
	{
		this.Alliances = Alliances;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Alliances.Length);
		foreach (AllianceFactSheetInformations item in this.Alliances)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int AlliancesLen = reader.ReadShort();
		Alliances = new AllianceFactSheetInformations[AlliancesLen];
		for (int i = 0; i < AlliancesLen; i++)
		{
			this.Alliances[i] = new AllianceFactSheetInformations();
			this.Alliances[i].Deserialize(reader);
		}
	}
}
}
