using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ActorOrientation : NetworkType
{

	public const uint Id = 353;
	public override uint MessageId { get { return Id; } }

	public double Id_ { get; set; }
	public byte Direction { get; set; }

	public ActorOrientation() {}


	public ActorOrientation InitActorOrientation(double Id_, byte Direction)
	{
		this.Id_ = Id_;
		this.Direction = Direction;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.Id_);
		writer.WriteByte(this.Direction);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadDouble();
		this.Direction = reader.ReadByte();
	}
}
}
