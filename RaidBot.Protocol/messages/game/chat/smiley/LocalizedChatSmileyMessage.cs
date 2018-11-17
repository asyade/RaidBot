using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LocalizedChatSmileyMessage : ChatSmileyMessage
{

	public const uint Id = 6185;
	public override uint MessageId { get { return Id; } }

	public short CellId { get; set; }

	public LocalizedChatSmileyMessage() {}


	public LocalizedChatSmileyMessage InitLocalizedChatSmileyMessage(short CellId)
	{
		this.CellId = CellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.CellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.CellId = reader.ReadVarShort();
	}
}
}
