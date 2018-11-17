using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class EmotePlayMessage : EmotePlayAbstractMessage
{

	public const uint Id = 5683;
	public override uint MessageId { get { return Id; } }

	public double ActorId { get; set; }
	public int AccountId { get; set; }

	public EmotePlayMessage() {}


	public EmotePlayMessage InitEmotePlayMessage(double ActorId, int AccountId)
	{
		this.ActorId = ActorId;
		this.AccountId = AccountId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.ActorId);
		writer.WriteInt(this.AccountId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.ActorId = reader.ReadDouble();
		this.AccountId = reader.ReadInt();
	}
}
}
