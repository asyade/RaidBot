using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class IgnoredDeleteRequestMessage : NetworkMessage
{

	public const uint Id = 5680;
	public override uint MessageId { get { return Id; } }

	public int AccountId { get; set; }
	public bool Session { get; set; }

	public IgnoredDeleteRequestMessage() {}


	public IgnoredDeleteRequestMessage InitIgnoredDeleteRequestMessage(int AccountId, bool Session)
	{
		this.AccountId = AccountId;
		this.Session = Session;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.AccountId);
		writer.WriteBoolean(this.Session);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AccountId = reader.ReadInt();
		this.Session = reader.ReadBoolean();
	}
}
}
