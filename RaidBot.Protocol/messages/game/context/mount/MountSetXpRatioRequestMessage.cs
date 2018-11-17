using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MountSetXpRatioRequestMessage : NetworkMessage
{

	public const uint Id = 5989;
	public override uint MessageId { get { return Id; } }

	public byte XpRatio { get; set; }

	public MountSetXpRatioRequestMessage() {}


	public MountSetXpRatioRequestMessage InitMountSetXpRatioRequestMessage(byte XpRatio)
	{
		this.XpRatio = XpRatio;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.XpRatio);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.XpRatio = reader.ReadByte();
	}
}
}
