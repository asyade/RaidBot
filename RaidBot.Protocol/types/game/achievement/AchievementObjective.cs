using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AchievementObjective : NetworkType
{

	public const uint Id = 404;
	public override uint MessageId { get { return Id; } }

	public int Id_ { get; set; }
	public short MaxValue { get; set; }

	public AchievementObjective() {}


	public AchievementObjective InitAchievementObjective(int Id_, short MaxValue)
	{
		this.Id_ = Id_;
		this.MaxValue = MaxValue;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.Id_);
		writer.WriteVarShort(this.MaxValue);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadVarInt();
		this.MaxValue = reader.ReadVarShort();
	}
}
}
