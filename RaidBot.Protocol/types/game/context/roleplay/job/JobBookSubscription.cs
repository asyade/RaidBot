using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobBookSubscription : NetworkType
{

	public const uint Id = 500;
	public override uint MessageId { get { return Id; } }

	public byte JobId { get; set; }
	public bool Subscribed { get; set; }

	public JobBookSubscription() {}


	public JobBookSubscription InitJobBookSubscription(byte JobId, bool Subscribed)
	{
		this.JobId = JobId;
		this.Subscribed = Subscribed;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.JobId);
		writer.WriteBoolean(this.Subscribed);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.JobId = reader.ReadByte();
		this.Subscribed = reader.ReadBoolean();
	}
}
}
