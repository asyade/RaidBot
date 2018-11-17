using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ShortcutBarRefreshMessage : NetworkMessage
{

	public const uint Id = 6229;
	public override uint MessageId { get { return Id; } }

	public byte BarType { get; set; }

	public ShortcutBarRefreshMessage() {}


	public ShortcutBarRefreshMessage InitShortcutBarRefreshMessage(byte BarType)
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
