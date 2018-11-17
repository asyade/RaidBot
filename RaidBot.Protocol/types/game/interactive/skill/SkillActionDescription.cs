using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SkillActionDescription : NetworkType
{

	public const uint Id = 102;
	public override uint MessageId { get { return Id; } }

	public short SkillId { get; set; }

	public SkillActionDescription() {}


	public SkillActionDescription InitSkillActionDescription(short SkillId)
	{
		this.SkillId = SkillId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SkillId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SkillId = reader.ReadVarShort();
	}
}
}
