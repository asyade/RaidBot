using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AchievementDetailsRequestMessage : NetworkMessage
{

	public const uint Id = 6380;
	public override uint MessageId { get { return Id; } }

	public short AchievementId { get; set; }

	public AchievementDetailsRequestMessage() {}


	public AchievementDetailsRequestMessage InitAchievementDetailsRequestMessage(short AchievementId)
	{
		this.AchievementId = AchievementId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.AchievementId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AchievementId = reader.ReadVarShort();
	}
}
}
