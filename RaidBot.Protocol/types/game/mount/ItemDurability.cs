using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ItemDurability : NetworkType
{

	public const uint Id = 168;
	public override uint MessageId { get { return Id; } }

	public short Durability { get; set; }
	public short DurabilityMax { get; set; }

	public ItemDurability() {}


	public ItemDurability InitItemDurability(short Durability, short DurabilityMax)
	{
		this.Durability = Durability;
		this.DurabilityMax = DurabilityMax;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Durability);
		writer.WriteShort(this.DurabilityMax);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Durability = reader.ReadShort();
		this.DurabilityMax = reader.ReadShort();
	}
}
}
