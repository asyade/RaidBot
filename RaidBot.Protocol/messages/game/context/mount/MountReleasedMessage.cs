using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MountReleasedMessage : NetworkMessage
{

	public const uint Id = 6308;
	public override uint MessageId { get { return Id; } }

	public int MountId { get; set; }

	public MountReleasedMessage() {}


	public MountReleasedMessage InitMountReleasedMessage(int MountId)
	{
		this.MountId = MountId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.MountId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MountId = reader.ReadVarInt();
	}
}
}
