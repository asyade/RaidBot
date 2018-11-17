using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobLevelUpMessage : NetworkMessage
{

	public const uint Id = 5656;
	public override uint MessageId { get { return Id; } }

	public byte NewLevel { get; set; }
	public JobDescription JobsDescription { get; set; }

	public JobLevelUpMessage() {}


	public JobLevelUpMessage InitJobLevelUpMessage(byte NewLevel, JobDescription JobsDescription)
	{
		this.NewLevel = NewLevel;
		this.JobsDescription = JobsDescription;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.NewLevel);
		this.JobsDescription.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.NewLevel = reader.ReadByte();
		this.JobsDescription = new JobDescription();
		this.JobsDescription.Deserialize(reader);
	}
}
}
