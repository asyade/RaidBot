using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectJobAddedMessage : NetworkMessage
{

	public const uint Id = 6014;
	public override uint MessageId { get { return Id; } }

	public byte JobId { get; set; }

	public ObjectJobAddedMessage() {}


	public ObjectJobAddedMessage InitObjectJobAddedMessage(byte JobId)
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
