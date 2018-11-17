using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobCrafterDirectoryListEntry : NetworkType
{

	public const uint Id = 196;
	public override uint MessageId { get { return Id; } }

	public JobCrafterDirectoryEntryPlayerInfo PlayerInfo { get; set; }
	public JobCrafterDirectoryEntryJobInfo JobInfo { get; set; }

	public JobCrafterDirectoryListEntry() {}


	public JobCrafterDirectoryListEntry InitJobCrafterDirectoryListEntry(JobCrafterDirectoryEntryPlayerInfo PlayerInfo, JobCrafterDirectoryEntryJobInfo JobInfo)
	{
		this.PlayerInfo = PlayerInfo;
		this.JobInfo = JobInfo;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.PlayerInfo.Serialize(writer);
		this.JobInfo.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PlayerInfo = new JobCrafterDirectoryEntryPlayerInfo();
		this.PlayerInfo.Deserialize(reader);
		this.JobInfo = new JobCrafterDirectoryEntryJobInfo();
		this.JobInfo.Deserialize(reader);
	}
}
}
