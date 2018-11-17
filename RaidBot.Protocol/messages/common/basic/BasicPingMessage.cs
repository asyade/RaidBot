using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class BasicPingMessage : NetworkMessage
{

	public const uint Id = 182;
	public override uint MessageId { get { return Id; } }

	public bool Quiet { get; set; }

	public BasicPingMessage() {}


	public BasicPingMessage InitBasicPingMessage(bool Quiet)
	{
		this.Quiet = Quiet;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Quiet);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Quiet = reader.ReadBoolean();
	}
}
}
