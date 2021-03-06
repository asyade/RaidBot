using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PopupWarningMessage : NetworkMessage
{

	public const uint Id = 6134;
	public override uint MessageId { get { return Id; } }

	public byte LockDuration { get; set; }
	public String Author { get; set; }
	public String Content { get; set; }

	public PopupWarningMessage() {}


	public PopupWarningMessage InitPopupWarningMessage(byte LockDuration, String Author, String Content)
	{
		this.LockDuration = LockDuration;
		this.Author = Author;
		this.Content = Content;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.LockDuration);
		writer.WriteUTF(this.Author);
		writer.WriteUTF(this.Content);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.LockDuration = reader.ReadByte();
		this.Author = reader.ReadUTF();
		this.Content = reader.ReadUTF();
	}
}
}
