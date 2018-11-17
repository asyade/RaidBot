using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ShortcutBarRemoveErrorMessage : NetworkMessage
{

	public const uint Id = 6222;
	public override uint MessageId { get { return Id; } }

	public byte Error { get; set; }

	public ShortcutBarRemoveErrorMessage() {}


	public ShortcutBarRemoveErrorMessage InitShortcutBarRemoveErrorMessage(byte Error)
	{
		this.Error = Error;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Error);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Error = reader.ReadByte();
	}
}
}
