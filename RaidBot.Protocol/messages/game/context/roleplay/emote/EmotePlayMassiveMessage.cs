using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class EmotePlayMassiveMessage : EmotePlayAbstractMessage
{

	public const uint Id = 5691;
	public override uint MessageId { get { return Id; } }

	public double[] ActorIds { get; set; }

	public EmotePlayMassiveMessage() {}


	public EmotePlayMassiveMessage InitEmotePlayMassiveMessage(double[] ActorIds)
	{
		this.ActorIds = ActorIds;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.ActorIds.Length);
		foreach (double item in this.ActorIds)
		{
			writer.WriteDouble(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		int ActorIdsLen = reader.ReadShort();
		ActorIds = new double[ActorIdsLen];
		for (int i = 0; i < ActorIdsLen; i++)
		{
			this.ActorIds[i] = reader.ReadDouble();
		}
	}
}
}
