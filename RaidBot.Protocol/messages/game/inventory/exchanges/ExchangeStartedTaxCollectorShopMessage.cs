using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeStartedTaxCollectorShopMessage : NetworkMessage
{

	public const uint Id = 6664;
	public override uint MessageId { get { return Id; } }

	public ObjectItem[] Objects { get; set; }
	public long Kamas { get; set; }

	public ExchangeStartedTaxCollectorShopMessage() {}


	public ExchangeStartedTaxCollectorShopMessage InitExchangeStartedTaxCollectorShopMessage(ObjectItem[] Objects, long Kamas)
	{
		this.Objects = Objects;
		this.Kamas = Kamas;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Objects.Length);
		foreach (ObjectItem item in this.Objects)
		{
			item.Serialize(writer);
		}
		writer.WriteVarLong(this.Kamas);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int ObjectsLen = reader.ReadShort();
		Objects = new ObjectItem[ObjectsLen];
		for (int i = 0; i < ObjectsLen; i++)
		{
			this.Objects[i] = new ObjectItem();
			this.Objects[i].Deserialize(reader);
		}
		this.Kamas = reader.ReadVarLong();
	}
}
}
