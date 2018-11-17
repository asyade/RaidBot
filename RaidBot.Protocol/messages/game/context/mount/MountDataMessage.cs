using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MountDataMessage : NetworkMessage
{

	public const uint Id = 5973;
	public override uint MessageId { get { return Id; } }

	public MountClientData MountData { get; set; }

	public MountDataMessage() {}


	public MountDataMessage InitMountDataMessage(MountClientData MountData)
	{
		this.MountData = MountData;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.MountData.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MountData = new MountClientData();
		this.MountData.Deserialize(reader);
	}
}
}
