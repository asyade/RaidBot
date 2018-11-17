using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobCrafterDirectorySettings : NetworkType
{

	public const uint Id = 97;
	public override uint MessageId { get { return Id; } }

	public byte JobId { get; set; }
	public byte MinLevel { get; set; }
	public bool Free { get; set; }

	public JobCrafterDirectorySettings() {}


	public JobCrafterDirectorySettings InitJobCrafterDirectorySettings(byte JobId, byte MinLevel, bool Free)
	{
		this.JobId = JobId;
		this.MinLevel = MinLevel;
		this.Free = Free;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.JobId);
		writer.WriteByte(this.MinLevel);
		writer.WriteBoolean(this.Free);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.JobId = reader.ReadByte();
		this.MinLevel = reader.ReadByte();
		this.Free = reader.ReadBoolean();
	}
}
}
