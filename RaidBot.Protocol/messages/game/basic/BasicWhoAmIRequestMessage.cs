using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class BasicWhoAmIRequestMessage : NetworkMessage
{

	public const uint Id = 5664;
	public override uint MessageId { get { return Id; } }

	public bool Verbose { get; set; }

	public BasicWhoAmIRequestMessage() {}


	public BasicWhoAmIRequestMessage InitBasicWhoAmIRequestMessage(bool Verbose)
	{
		this.Verbose = Verbose;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Verbose);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Verbose = reader.ReadBoolean();
	}
}
}
