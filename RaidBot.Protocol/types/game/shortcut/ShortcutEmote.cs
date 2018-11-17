using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ShortcutEmote : Shortcut
{

	public const uint Id = 389;
	public override uint MessageId { get { return Id; } }

	public byte EmoteId { get; set; }

	public ShortcutEmote() {}


	public ShortcutEmote InitShortcutEmote(byte EmoteId)
	{
		this.EmoteId = EmoteId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.EmoteId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.EmoteId = reader.ReadByte();
	}
}
}
