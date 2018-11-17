using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MailStatusMessage : NetworkMessage
{

	public const uint Id = 6275;
	public override uint MessageId { get { return Id; } }

	public short Unread { get; set; }
	public short Total { get; set; }

	public MailStatusMessage() {}


	public MailStatusMessage InitMailStatusMessage(short Unread, short Total)
	{
		this.Unread = Unread;
		this.Total = Total;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.Unread);
		writer.WriteVarShort(this.Total);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Unread = reader.ReadVarShort();
		this.Total = reader.ReadVarShort();
	}
}
}
