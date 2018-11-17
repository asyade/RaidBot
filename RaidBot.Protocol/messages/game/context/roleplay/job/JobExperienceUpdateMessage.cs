using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobExperienceUpdateMessage : NetworkMessage
{

	public const uint Id = 5654;
	public override uint MessageId { get { return Id; } }

	public JobExperience ExperiencesUpdate { get; set; }

	public JobExperienceUpdateMessage() {}


	public JobExperienceUpdateMessage InitJobExperienceUpdateMessage(JobExperience ExperiencesUpdate)
	{
		this.ExperiencesUpdate = ExperiencesUpdate;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.ExperiencesUpdate.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ExperiencesUpdate = new JobExperience();
		this.ExperiencesUpdate.Deserialize(reader);
	}
}
}
