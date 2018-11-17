using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ChatClientPrivateMessage : ChatAbstractClientMessage
{

	public const uint Id = 851;
	public override uint MessageId { get { return Id; } }

	public String Receiver { get; set; }

	public ChatClientPrivateMessage() {}


	public ChatClientPrivateMessage InitChatClientPrivateMessage(String Receiver)
	{
		this.Receiver = Receiver;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.Receiver);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Receiver = reader.ReadUTF();
	}
}
}
