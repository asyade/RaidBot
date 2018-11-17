using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ShortcutBarReplacedMessage : NetworkMessage
{

	public const uint Id = 6706;
	public override uint MessageId { get { return Id; } }

	public byte BarType { get; set; }

	public ShortcutBarReplacedMessage() {}


	public ShortcutBarReplacedMessage InitShortcutBarReplacedMessage(byte BarType)
	{
		this.BarType = BarType;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.BarType);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.BarType = reader.ReadByte();
	}
}
}
