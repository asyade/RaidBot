using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ChatServerCopyMessage : ChatAbstractServerMessage
{

	public const uint Id = 882;
	public override uint MessageId { get { return Id; } }

	public long ReceiverId { get; set; }
	public String ReceiverName { get; set; }

	public ChatServerCopyMessage() {}


	public ChatServerCopyMessage InitChatServerCopyMessage(long ReceiverId, String ReceiverName)
	{
		this.ReceiverId = ReceiverId;
		this.ReceiverName = ReceiverName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.ReceiverId);
		writer.WriteUTF(this.ReceiverName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.ReceiverId = reader.ReadVarLong();
		this.ReceiverName = reader.ReadUTF();
	}
}
}
