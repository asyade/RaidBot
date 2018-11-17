using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class InteractiveElementSkill : NetworkType
{

	public const uint Id = 219;
	public override uint MessageId { get { return Id; } }

	public int SkillId { get; set; }
	public int SkillInstanceUid { get; set; }

	public InteractiveElementSkill() {}


	public InteractiveElementSkill InitInteractiveElementSkill(int SkillId, int SkillInstanceUid)
	{
		this.SkillId = SkillId;
		this.SkillInstanceUid = SkillInstanceUid;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.SkillId);
		writer.WriteInt(this.SkillInstanceUid);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SkillId = reader.ReadVarInt();
		this.SkillInstanceUid = reader.ReadInt();
	}
}
}
