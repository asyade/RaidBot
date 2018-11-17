using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AllianceFactSheetInformations : AllianceInformations
{

	public const uint Id = 421;
	public override uint MessageId { get { return Id; } }

	public int CreationDate { get; set; }

	public AllianceFactSheetInformations() {}


	public AllianceFactSheetInformations InitAllianceFactSheetInformations(int CreationDate)
	{
		this.CreationDate = CreationDate;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteInt(this.CreationDate);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.CreationDate = reader.ReadInt();
	}
}
}
