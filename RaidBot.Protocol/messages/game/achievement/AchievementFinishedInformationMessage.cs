using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AchievementFinishedInformationMessage : AchievementFinishedMessage
{

	public const uint Id = 6381;
	public override uint MessageId { get { return Id; } }

	public String Name { get; set; }
	public long PlayerId { get; set; }

	public AchievementFinishedInformationMessage() {}


	public AchievementFinishedInformationMessage InitAchievementFinishedInformationMessage(String Name, long PlayerId)
	{
		this.Name = Name;
		this.PlayerId = PlayerId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.Name);
		writer.WriteVarLong(this.PlayerId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Name = reader.ReadUTF();
		this.PlayerId = reader.ReadVarLong();
	}
}
}
