using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class IgnoredAddedMessage : NetworkMessage
{

	public const uint Id = 5678;
	public override uint MessageId { get { return Id; } }

	public bool Session { get; set; }

	public IgnoredAddedMessage() {}


	public IgnoredAddedMessage InitIgnoredAddedMessage(bool Session)
	{
		this.Session = Session;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Session);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Session = reader.ReadBoolean();
	}
}
}
