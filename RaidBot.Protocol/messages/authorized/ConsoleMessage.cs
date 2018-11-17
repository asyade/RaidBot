using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ConsoleMessage : NetworkMessage
{

	public const uint Id = 75;
	public override uint MessageId { get { return Id; } }

	public byte Type { get; set; }
	public String Content { get; set; }

	public ConsoleMessage() {}


	public ConsoleMessage InitConsoleMessage(byte Type, String Content)
	{
		this.Type = Type;
		this.Content = Content;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Type);
		writer.WriteUTF(this.Content);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Type = reader.ReadByte();
		this.Content = reader.ReadUTF();
	}
}
}
