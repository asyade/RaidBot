using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LifePointsRegenBeginMessage : NetworkMessage
{

	public const uint Id = 5684;
	public override uint MessageId { get { return Id; } }

	public byte RegenRate { get; set; }

	public LifePointsRegenBeginMessage() {}


	public LifePointsRegenBeginMessage InitLifePointsRegenBeginMessage(byte RegenRate)
	{
		this.RegenRate = RegenRate;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.RegenRate);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.RegenRate = reader.ReadByte();
	}
}
}
