using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class InteractiveUsedMessage : NetworkMessage
{

	public const uint Id = 5745;
	public override uint MessageId { get { return Id; } }

	public long EntityId { get; set; }
	public int ElemId { get; set; }
	public short SkillId { get; set; }
	public short Duration { get; set; }
	public bool CanMove { get; set; }

	public InteractiveUsedMessage() {}


	public InteractiveUsedMessage InitInteractiveUsedMessage(long EntityId, int ElemId, short SkillId, short Duration, bool CanMove)
	{
		this.EntityId = EntityId;
		this.ElemId = ElemId;
		this.SkillId = SkillId;
		this.Duration = Duration;
		this.CanMove = CanMove;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.EntityId);
		writer.WriteVarInt(this.ElemId);
		writer.WriteVarShort(this.SkillId);
		writer.WriteVarShort(this.Duration);
		writer.WriteBoolean(this.CanMove);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.EntityId = reader.ReadVarLong();
		this.ElemId = reader.ReadVarInt();
		this.SkillId = reader.ReadVarShort();
		this.Duration = reader.ReadVarShort();
		this.CanMove = reader.ReadBoolean();
	}
}
}
