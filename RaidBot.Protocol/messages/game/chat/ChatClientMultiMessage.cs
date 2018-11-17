using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ChatClientMultiMessage : ChatAbstractClientMessage
{

	public const uint Id = 861;
	public override uint MessageId { get { return Id; } }

	public byte Channel { get; set; }

	public ChatClientMultiMessage() {}


	public ChatClientMultiMessage InitChatClientMultiMessage(byte Channel)
	{
		this.Channel = Channel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.Channel);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Channel = reader.ReadByte();
	}
}
}
