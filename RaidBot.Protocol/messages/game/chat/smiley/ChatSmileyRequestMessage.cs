using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ChatSmileyRequestMessage : NetworkMessage
{

	public const uint Id = 800;
	public override uint MessageId { get { return Id; } }

	public short SmileyId { get; set; }

	public ChatSmileyRequestMessage() {}


	public ChatSmileyRequestMessage InitChatSmileyRequestMessage(short SmileyId)
	{
		this.SmileyId = SmileyId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SmileyId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SmileyId = reader.ReadVarShort();
	}
}
}
