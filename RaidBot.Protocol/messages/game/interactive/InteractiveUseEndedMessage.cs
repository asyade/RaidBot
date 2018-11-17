using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class InteractiveUseEndedMessage : NetworkMessage
{

	public const uint Id = 6112;
	public override uint MessageId { get { return Id; } }

	public int ElemId { get; set; }
	public short SkillId { get; set; }

	public InteractiveUseEndedMessage() {}


	public InteractiveUseEndedMessage InitInteractiveUseEndedMessage(int ElemId, short SkillId)
	{
		this.ElemId = ElemId;
		this.SkillId = SkillId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.ElemId);
		writer.WriteVarShort(this.SkillId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ElemId = reader.ReadVarInt();
		this.SkillId = reader.ReadVarShort();
	}
}
}
