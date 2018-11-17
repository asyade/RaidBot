using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayPlayerFightFriendlyRequestedMessage : NetworkMessage
{

	public const uint Id = 5937;
	public override uint MessageId { get { return Id; } }

	public short FightId { get; set; }
	public long SourceId { get; set; }
	public long TargetId { get; set; }

	public GameRolePlayPlayerFightFriendlyRequestedMessage() {}


	public GameRolePlayPlayerFightFriendlyRequestedMessage InitGameRolePlayPlayerFightFriendlyRequestedMessage(short FightId, long SourceId, long TargetId)
	{
		this.FightId = FightId;
		this.SourceId = SourceId;
		this.TargetId = TargetId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.FightId);
		writer.WriteVarLong(this.SourceId);
		writer.WriteVarLong(this.TargetId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FightId = reader.ReadVarShort();
		this.SourceId = reader.ReadVarLong();
		this.TargetId = reader.ReadVarLong();
	}
}
}
