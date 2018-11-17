using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobAllowMultiCraftRequestMessage : NetworkMessage
{

	public const uint Id = 5748;
	public override uint MessageId { get { return Id; } }

	public bool Enabled { get; set; }

	public JobAllowMultiCraftRequestMessage() {}


	public JobAllowMultiCraftRequestMessage InitJobAllowMultiCraftRequestMessage(bool Enabled)
	{
		this.Enabled = Enabled;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Enabled);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Enabled = reader.ReadBoolean();
	}
}
}
