using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AchievementAchievedRewardable : AchievementAchieved
{

	public const uint Id = 515;
	public override uint MessageId { get { return Id; } }

	public short Finishedlevel { get; set; }

	public AchievementAchievedRewardable() {}


	public AchievementAchievedRewardable InitAchievementAchievedRewardable(short Finishedlevel)
	{
		this.Finishedlevel = Finishedlevel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.Finishedlevel);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Finishedlevel = reader.ReadVarShort();
	}
}
}
