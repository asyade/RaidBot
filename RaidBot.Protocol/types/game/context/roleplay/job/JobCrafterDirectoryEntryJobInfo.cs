using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobCrafterDirectoryEntryJobInfo : NetworkType
{

	public const uint Id = 195;
	public override uint MessageId { get { return Id; } }

	public byte JobId { get; set; }
	public byte JobLevel { get; set; }
	public bool Free { get; set; }
	public byte MinLevel { get; set; }

	public JobCrafterDirectoryEntryJobInfo() {}


	public JobCrafterDirectoryEntryJobInfo InitJobCrafterDirectoryEntryJobInfo(byte JobId, byte JobLevel, bool Free, byte MinLevel)
	{
		this.JobId = JobId;
		this.JobLevel = JobLevel;
		this.Free = Free;
		this.MinLevel = MinLevel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.JobId);
		writer.WriteByte(this.JobLevel);
		writer.WriteBoolean(this.Free);
		writer.WriteByte(this.MinLevel);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.JobId = reader.ReadByte();
		this.JobLevel = reader.ReadByte();
		this.Free = reader.ReadBoolean();
		this.MinLevel = reader.ReadByte();
	}
}
}
