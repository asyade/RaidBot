using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightSlideMessage : AbstractGameActionMessage
{

	public const uint Id = 5525;
	public override uint MessageId { get { return Id; } }

	public double TargetId { get; set; }
	public short StartCellId { get; set; }
	public short EndCellId { get; set; }

	public GameActionFightSlideMessage() {}


	public GameActionFightSlideMessage InitGameActionFightSlideMessage(double TargetId, short StartCellId, short EndCellId)
	{
		this.TargetId = TargetId;
		this.StartCellId = StartCellId;
		this.EndCellId = EndCellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.TargetId);
		writer.WriteShort(this.StartCellId);
		writer.WriteShort(this.EndCellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.TargetId = reader.ReadDouble();
		this.StartCellId = reader.ReadShort();
		this.EndCellId = reader.ReadShort();
	}
}
}
