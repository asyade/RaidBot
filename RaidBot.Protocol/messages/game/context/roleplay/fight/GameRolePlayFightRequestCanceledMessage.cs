using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayFightRequestCanceledMessage : NetworkMessage
{

	public const uint Id = 5822;
	public override uint MessageId { get { return Id; } }

	public short FightId { get; set; }
	public double SourceId { get; set; }
	public double TargetId { get; set; }

	public GameRolePlayFightRequestCanceledMessage() {}


	public GameRolePlayFightRequestCanceledMessage InitGameRolePlayFightRequestCanceledMessage(short FightId, double SourceId, double TargetId)
	{
		this.FightId = FightId;
		this.SourceId = SourceId;
		this.TargetId = TargetId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.FightId);
		writer.WriteDouble(this.SourceId);
		writer.WriteDouble(this.TargetId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FightId = reader.ReadVarShort();
		this.SourceId = reader.ReadDouble();
		this.TargetId = reader.ReadDouble();
	}
}
}
