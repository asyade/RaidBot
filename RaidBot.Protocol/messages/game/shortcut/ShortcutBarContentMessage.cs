using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ShortcutBarContentMessage : NetworkMessage
{

	public const uint Id = 6231;
	public override uint MessageId { get { return Id; } }

	public byte BarType { get; set; }
	public Shortcut[] Shortcuts { get; set; }

	public ShortcutBarContentMessage() {}


	public ShortcutBarContentMessage InitShortcutBarContentMessage(byte BarType, Shortcut[] Shortcuts)
	{
		this.BarType = BarType;
		this.Shortcuts = Shortcuts;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.BarType);
		writer.WriteShort(this.Shortcuts.Length);
		foreach (Shortcut item in this.Shortcuts)
		{
			writer.WriteShort(item.MessageId);
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.BarType = reader.ReadByte();
		int ShortcutsLen = reader.ReadShort();
		Shortcuts = new Shortcut[ShortcutsLen];
		for (int i = 0; i < ShortcutsLen; i++)
		{
			this.Shortcuts[i] = ProtocolTypeManager.GetInstance<Shortcut>(reader.ReadShort());
			this.Shortcuts[i].Deserialize(reader);
		}
	}
}
}
