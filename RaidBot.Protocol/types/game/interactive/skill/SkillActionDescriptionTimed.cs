using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SkillActionDescriptionTimed : SkillActionDescription
{

	public const uint Id = 103;
	public override uint MessageId { get { return Id; } }

	public byte Time { get; set; }

	public SkillActionDescriptionTimed() {}


	public SkillActionDescriptionTimed InitSkillActionDescriptionTimed(byte Time)
	{
		this.Time = Time;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.Time);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Time = reader.ReadByte();
	}
}
}
