using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayPlayerFightRequestMessage : NetworkMessage
{

	public const uint Id = 5731;
	public override uint MessageId { get { return Id; } }

	public long TargetId { get; set; }
	public short TargetCellId { get; set; }
	public bool Friendly { get; set; }

	public GameRolePlayPlayerFightRequestMessage() {}


	public GameRolePlayPlayerFightRequestMessage InitGameRolePlayPlayerFightRequestMessage(long TargetId, short TargetCellId, bool Friendly)
	{
		this.TargetId = TargetId;
		this.TargetCellId = TargetCellId;
		this.Friendly = Friendly;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.TargetId);
		writer.WriteShort(this.TargetCellId);
		writer.WriteBoolean(this.Friendly);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.TargetId = reader.ReadVarLong();
		this.TargetCellId = reader.ReadShort();
		this.Friendly = reader.ReadBoolean();
	}
}
}
