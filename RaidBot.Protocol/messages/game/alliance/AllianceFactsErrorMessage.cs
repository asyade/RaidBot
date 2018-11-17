using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AllianceFactsErrorMessage : NetworkMessage
{

	public const uint Id = 6423;
	public override uint MessageId { get { return Id; } }

	public int AllianceId { get; set; }

	public AllianceFactsErrorMessage() {}


	public AllianceFactsErrorMessage InitAllianceFactsErrorMessage(int AllianceId)
	{
		this.AllianceId = AllianceId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.AllianceId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AllianceId = reader.ReadVarInt();
	}
}
}
