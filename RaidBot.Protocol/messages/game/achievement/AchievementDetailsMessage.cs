using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AchievementDetailsMessage : NetworkMessage
{

	public const uint Id = 6378;
	public override uint MessageId { get { return Id; } }

	public Achievement Achievement { get; set; }

	public AchievementDetailsMessage() {}


	public AchievementDetailsMessage InitAchievementDetailsMessage(Achievement Achievement)
	{
		this.Achievement = Achievement;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Achievement.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Achievement = new Achievement();
		this.Achievement.Deserialize(reader);
	}
}
}
