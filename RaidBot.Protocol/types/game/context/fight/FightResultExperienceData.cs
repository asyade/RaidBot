using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightResultExperienceData : FightResultAdditionalData
{

	public const uint Id = 192;
	public override uint MessageId { get { return Id; } }

	public bool ShowExperience { get; set; }
	public bool ShowExperienceLevelFloor { get; set; }
	public bool ShowExperienceNextLevelFloor { get; set; }
	public bool ShowExperienceFightDelta { get; set; }
	public bool ShowExperienceForGuild { get; set; }
	public bool ShowExperienceForMount { get; set; }
	public bool IsIncarnationExperience { get; set; }
	public long Experience { get; set; }
	public long ExperienceLevelFloor { get; set; }
	public long ExperienceNextLevelFloor { get; set; }
	public long ExperienceFightDelta { get; set; }
	public long ExperienceForGuild { get; set; }
	public long ExperienceForMount { get; set; }
	public byte RerollExperienceMul { get; set; }

	public FightResultExperienceData() {}


	public FightResultExperienceData InitFightResultExperienceData(bool ShowExperience, bool ShowExperienceLevelFloor, bool ShowExperienceNextLevelFloor, bool ShowExperienceFightDelta, bool ShowExperienceForGuild, bool ShowExperienceForMount, bool IsIncarnationExperience, long Experience, long ExperienceLevelFloor, long ExperienceNextLevelFloor, long ExperienceFightDelta, long ExperienceForGuild, long ExperienceForMount, byte RerollExperienceMul)
	{
		this.ShowExperience = ShowExperience;
		this.ShowExperienceLevelFloor = ShowExperienceLevelFloor;
		this.ShowExperienceNextLevelFloor = ShowExperienceNextLevelFloor;
		this.ShowExperienceFightDelta = ShowExperienceFightDelta;
		this.ShowExperienceForGuild = ShowExperienceForGuild;
		this.ShowExperienceForMount = ShowExperienceForMount;
		this.IsIncarnationExperience = IsIncarnationExperience;
		this.Experience = Experience;
		this.ExperienceLevelFloor = ExperienceLevelFloor;
		this.ExperienceNextLevelFloor = ExperienceNextLevelFloor;
		this.ExperienceFightDelta = ExperienceFightDelta;
		this.ExperienceForGuild = ExperienceForGuild;
		this.ExperienceForMount = ExperienceForMount;
		this.RerollExperienceMul = RerollExperienceMul;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, ShowExperience);
		box = BooleanByteWrapper.SetFlag(box, 1, ShowExperienceLevelFloor);
		box = BooleanByteWrapper.SetFlag(box, 2, ShowExperienceNextLevelFloor);
		box = BooleanByteWrapper.SetFlag(box, 3, ShowExperienceFightDelta);
		box = BooleanByteWrapper.SetFlag(box, 4, ShowExperienceForGuild);
		box = BooleanByteWrapper.SetFlag(box, 5, ShowExperienceForMount);
		box = BooleanByteWrapper.SetFlag(box, 6, IsIncarnationExperience);
		writer.WriteByte(box);
		writer.WriteVarLong(this.Experience);
		writer.WriteVarLong(this.ExperienceLevelFloor);
		writer.WriteVarLong(this.ExperienceNextLevelFloor);
		writer.WriteVarLong(this.ExperienceFightDelta);
		writer.WriteVarLong(this.ExperienceForGuild);
		writer.WriteVarLong(this.ExperienceForMount);
		writer.WriteByte(this.RerollExperienceMul);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		byte box = reader.ReadByte();
		this.ShowExperience = BooleanByteWrapper.GetFlag(box, 0);
		this.ShowExperienceLevelFloor = BooleanByteWrapper.GetFlag(box, 1);
		this.ShowExperienceNextLevelFloor = BooleanByteWrapper.GetFlag(box, 2);
		this.ShowExperienceFightDelta = BooleanByteWrapper.GetFlag(box, 3);
		this.ShowExperienceForGuild = BooleanByteWrapper.GetFlag(box, 4);
		this.ShowExperienceForMount = BooleanByteWrapper.GetFlag(box, 5);
		this.IsIncarnationExperience = BooleanByteWrapper.GetFlag(box, 6);
		this.Experience = reader.ReadVarLong();
		this.ExperienceLevelFloor = reader.ReadVarLong();
		this.ExperienceNextLevelFloor = reader.ReadVarLong();
		this.ExperienceFightDelta = reader.ReadVarLong();
		this.ExperienceForGuild = reader.ReadVarLong();
		this.ExperienceForMount = reader.ReadVarLong();
		this.RerollExperienceMul = reader.ReadByte();
	}
}
}
