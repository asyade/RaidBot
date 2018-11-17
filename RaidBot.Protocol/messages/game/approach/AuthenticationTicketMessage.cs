using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AuthenticationTicketMessage : NetworkMessage
{

	public const uint Id = 110;
	public override uint MessageId { get { return Id; } }

	public String Lang { get; set; }
	public String Ticket { get; set; }

	public AuthenticationTicketMessage() {}


	public AuthenticationTicketMessage InitAuthenticationTicketMessage(String Lang, String Ticket)
	{
		this.Lang = Lang;
		this.Ticket = Ticket;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Lang);
		writer.WriteUTF(this.Ticket);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Lang = reader.ReadUTF();
		this.Ticket = reader.ReadUTF();
	}
}
}
