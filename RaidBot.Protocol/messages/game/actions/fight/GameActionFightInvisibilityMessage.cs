using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightInvisibilityMessage : AbstractGameActionMessage
{

	public const uint Id = 5821;
	public override uint MessageId { get { return Id; } }

	public double TargetId { get; set; }
	public byte State { get; set; }

	public GameActionFightInvisibilityMessage() {}


	public GameActionFightInvisibilityMessage InitGameActionFightInvisibilityMessage(double TargetId, byte State)
	{
		this.TargetId = TargetId;
		this.State = State;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.TargetId);
		writer.WriteByte(this.State);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.TargetId = reader.ReadDouble();
		this.State = reader.ReadByte();
	}
}
}
