using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SkillActionDescriptionCraft : SkillActionDescription
{

	public const uint Id = 100;
	public override uint MessageId { get { return Id; } }

	public byte Probability { get; set; }

	public SkillActionDescriptionCraft() {}


	public SkillActionDescriptionCraft InitSkillActionDescriptionCraft(byte Probability)
	{
		this.Probability = Probability;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.Probability);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Probability = reader.ReadByte();
	}
}
}
