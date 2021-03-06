using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobCrafterDirectoryEntryMessage : NetworkMessage
{

	public const uint Id = 6044;
	public override uint MessageId { get { return Id; } }

	public JobCrafterDirectoryEntryPlayerInfo PlayerInfo { get; set; }
	public JobCrafterDirectoryEntryJobInfo[] JobInfoList { get; set; }
	public EntityLook PlayerLook { get; set; }

	public JobCrafterDirectoryEntryMessage() {}


	public JobCrafterDirectoryEntryMessage InitJobCrafterDirectoryEntryMessage(JobCrafterDirectoryEntryPlayerInfo PlayerInfo, JobCrafterDirectoryEntryJobInfo[] JobInfoList, EntityLook PlayerLook)
	{
		this.PlayerInfo = PlayerInfo;
		this.JobInfoList = JobInfoList;
		this.PlayerLook = PlayerLook;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.PlayerInfo.Serialize(writer);
		writer.WriteShort(this.JobInfoList.Length);
		foreach (JobCrafterDirectoryEntryJobInfo item in this.JobInfoList)
		{
			item.Serialize(writer);
		}
		this.PlayerLook.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PlayerInfo = new JobCrafterDirectoryEntryPlayerInfo();
		this.PlayerInfo.Deserialize(reader);
		int JobInfoListLen = reader.ReadShort();
		JobInfoList = new JobCrafterDirectoryEntryJobInfo[JobInfoListLen];
		for (int i = 0; i < JobInfoListLen; i++)
		{
			this.JobInfoList[i] = new JobCrafterDirectoryEntryJobInfo();
			this.JobInfoList[i].Deserialize(reader);
		}
		this.PlayerLook = new EntityLook();
		this.PlayerLook.Deserialize(reader);
	}
}
}
