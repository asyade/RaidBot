using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SpellItem : Item
{

	public const uint Id = 49;
	public override uint MessageId { get { return Id; } }

	public int SpellId { get; set; }
	public short SpellLevel { get; set; }

	public SpellItem() {}


	public SpellItem InitSpellItem(int SpellId, short SpellLevel)
	{
		this.SpellId = SpellId;
		this.SpellLevel = SpellLevel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteInt(this.SpellId);
		writer.WriteShort(this.SpellLevel);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.SpellId = reader.ReadInt();
		this.SpellLevel = reader.ReadShort();
	}
}
}
