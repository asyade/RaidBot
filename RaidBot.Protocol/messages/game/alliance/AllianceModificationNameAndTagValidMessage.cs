using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AllianceModificationNameAndTagValidMessage : NetworkMessage
{

	public const uint Id = 6449;
	public override uint MessageId { get { return Id; } }

	public String AllianceName { get; set; }
	public String AllianceTag { get; set; }

	public AllianceModificationNameAndTagValidMessage() {}


	public AllianceModificationNameAndTagValidMessage InitAllianceModificationNameAndTagValidMessage(String AllianceName, String AllianceTag)
	{
		this.AllianceName = AllianceName;
		this.AllianceTag = AllianceTag;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.AllianceName);
		writer.WriteUTF(this.AllianceTag);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AllianceName = reader.ReadUTF();
		this.AllianceTag = reader.ReadUTF();
	}
}
}
