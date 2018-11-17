using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayShowActorWithEventMessage : GameRolePlayShowActorMessage
{

	public const uint Id = 6407;
	public override uint MessageId { get { return Id; } }

	public byte ActorEventId { get; set; }

	public GameRolePlayShowActorWithEventMessage() {}


	public GameRolePlayShowActorWithEventMessage InitGameRolePlayShowActorWithEventMessage(byte ActorEventId)
	{
		this.ActorEventId = ActorEventId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.ActorEventId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.ActorEventId = reader.ReadByte();
	}
}
}
