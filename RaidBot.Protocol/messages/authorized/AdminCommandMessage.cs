using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AdminCommandMessage : NetworkMessage
{

	public const uint Id = 76;
	public override uint MessageId { get { return Id; } }

	public String Content { get; set; }

	public AdminCommandMessage() {}


	public AdminCommandMessage InitAdminCommandMessage(String Content)
	{
		this.Content = Content;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Content);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Content = reader.ReadUTF();
	}
}
}
