using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HumanOptionSkillUse : HumanOption
{

	public const uint Id = 495;
	public override uint MessageId { get { return Id; } }

	public int ElementId { get; set; }
	public short SkillId { get; set; }
	public double SkillEndTime { get; set; }

	public HumanOptionSkillUse() {}


	public HumanOptionSkillUse InitHumanOptionSkillUse(int ElementId, short SkillId, double SkillEndTime)
	{
		this.ElementId = ElementId;
		this.SkillId = SkillId;
		this.SkillEndTime = SkillEndTime;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.ElementId);
		writer.WriteVarShort(this.SkillId);
		writer.WriteDouble(this.SkillEndTime);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.ElementId = reader.ReadVarInt();
		this.SkillId = reader.ReadVarShort();
		this.SkillEndTime = reader.ReadDouble();
	}
}
}
