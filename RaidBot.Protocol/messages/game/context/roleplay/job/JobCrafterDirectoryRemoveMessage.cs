using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobCrafterDirectoryRemoveMessage : NetworkMessage
{

	public const uint Id = 5653;
	public override uint MessageId { get { return Id; } }

	public byte JobId { get; set; }
	public long PlayerId { get; set; }

	public JobCrafterDirectoryRemoveMessage() {}


	public JobCrafterDirectoryRemoveMessage InitJobCrafterDirectoryRemoveMessage(byte JobId, long PlayerId)
	{
		this.JobId = JobId;
		this.PlayerId = PlayerId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.JobId);
		writer.WriteVarLong(this.PlayerId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.JobId = reader.ReadByte();
		this.PlayerId = reader.ReadVarLong();
	}
}
}
