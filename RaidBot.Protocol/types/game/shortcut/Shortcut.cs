using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class Shortcut : NetworkType
{

	public const uint Id = 369;
	public override uint MessageId { get { return Id; } }

	public byte Slot { get; set; }

	public Shortcut() {}


	public Shortcut InitShortcut(byte Slot)
	{
		this.Slot = Slot;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Slot);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Slot = reader.ReadByte();
	}
}
}
