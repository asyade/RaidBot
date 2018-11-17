using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AchievementAchieved : NetworkType
{

	public const uint Id = 514;
	public override uint MessageId { get { return Id; } }

	public short Id_ { get; set; }
	public long AchievedBy { get; set; }

	public AchievementAchieved() {}


	public AchievementAchieved InitAchievementAchieved(short Id_, long AchievedBy)
	{
		this.Id_ = Id_;
		this.AchievedBy = AchievedBy;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.Id_);
		writer.WriteVarLong(this.AchievedBy);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadVarShort();
		this.AchievedBy = reader.ReadVarLong();
	}
}
}
