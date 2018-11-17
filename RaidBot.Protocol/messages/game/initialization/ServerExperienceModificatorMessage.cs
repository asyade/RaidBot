using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ServerExperienceModificatorMessage : NetworkMessage
{

	public const uint Id = 6237;
	public override uint MessageId { get { return Id; } }

	public short ExperiencePercent { get; set; }

	public ServerExperienceModificatorMessage() {}


	public ServerExperienceModificatorMessage InitServerExperienceModificatorMessage(short ExperiencePercent)
	{
		this.ExperiencePercent = ExperiencePercent;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ExperiencePercent);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ExperiencePercent = reader.ReadVarShort();
	}
}
}
