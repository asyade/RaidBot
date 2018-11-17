using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MountXpRatioMessage : NetworkMessage
{

	public const uint Id = 5970;
	public override uint MessageId { get { return Id; } }

	public byte Ratio { get; set; }

	public MountXpRatioMessage() {}


	public MountXpRatioMessage InitMountXpRatioMessage(byte Ratio)
	{
		this.Ratio = Ratio;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Ratio);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Ratio = reader.ReadByte();
	}
}
}
