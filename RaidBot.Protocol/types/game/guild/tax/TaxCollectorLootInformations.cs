using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TaxCollectorLootInformations : TaxCollectorComplementaryInformations
{

	public const uint Id = 372;
	public override uint MessageId { get { return Id; } }

	public long Kamas { get; set; }
	public long Experience { get; set; }
	public int Pods { get; set; }
	public long ItemsValue { get; set; }

	public TaxCollectorLootInformations() {}


	public TaxCollectorLootInformations InitTaxCollectorLootInformations(long Kamas, long Experience, int Pods, long ItemsValue)
	{
		this.Kamas = Kamas;
		this.Experience = Experience;
		this.Pods = Pods;
		this.ItemsValue = ItemsValue;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.Kamas);
		writer.WriteVarLong(this.Experience);
		writer.WriteVarInt(this.Pods);
		writer.WriteVarLong(this.ItemsValue);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Kamas = reader.ReadVarLong();
		this.Experience = reader.ReadVarLong();
		this.Pods = reader.ReadVarInt();
		this.ItemsValue = reader.ReadVarLong();
	}
}
}
