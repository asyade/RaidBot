using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ContactLookRequestByNameMessage : ContactLookRequestMessage
{

	public const uint Id = 5933;
	public override uint MessageId { get { return Id; } }

	public String PlayerName { get; set; }

	public ContactLookRequestByNameMessage() {}


	public ContactLookRequestByNameMessage InitContactLookRequestByNameMessage(String PlayerName)
	{
		this.PlayerName = PlayerName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.PlayerName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.PlayerName = reader.ReadUTF();
	}
}
}
