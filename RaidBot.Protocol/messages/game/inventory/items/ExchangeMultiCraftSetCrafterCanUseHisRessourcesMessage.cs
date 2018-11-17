using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage : NetworkMessage
{

	public const uint Id = 6021;
	public override uint MessageId { get { return Id; } }

	public bool Allow { get; set; }

	public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage() {}


	public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage InitExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage(bool Allow)
	{
		this.Allow = Allow;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Allow);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Allow = reader.ReadBoolean();
	}
}
}
