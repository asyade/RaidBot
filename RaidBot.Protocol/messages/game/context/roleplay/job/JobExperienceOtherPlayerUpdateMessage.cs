using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobExperienceOtherPlayerUpdateMessage : JobExperienceUpdateMessage
{

	public const uint Id = 6599;
	public override uint MessageId { get { return Id; } }

	public long PlayerId { get; set; }

	public JobExperienceOtherPlayerUpdateMessage() {}


	public JobExperienceOtherPlayerUpdateMessage InitJobExperienceOtherPlayerUpdateMessage(long PlayerId)
	{
		this.PlayerId = PlayerId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.PlayerId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.PlayerId = reader.ReadVarLong();
	}
}
}
