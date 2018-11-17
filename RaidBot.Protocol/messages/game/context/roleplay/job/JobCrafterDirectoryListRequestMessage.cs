using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobCrafterDirectoryListRequestMessage : NetworkMessage
{

	public const uint Id = 6047;
	public override uint MessageId { get { return Id; } }

	public byte JobId { get; set; }

	public JobCrafterDirectoryListRequestMessage() {}


	public JobCrafterDirectoryListRequestMessage InitJobCrafterDirectoryListRequestMessage(byte JobId)
	{
		this.JobId = JobId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.JobId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.JobId = reader.ReadByte();
	}
}
}
