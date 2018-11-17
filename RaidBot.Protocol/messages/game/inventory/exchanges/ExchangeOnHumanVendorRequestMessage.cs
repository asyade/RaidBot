using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeOnHumanVendorRequestMessage : NetworkMessage
{

	public const uint Id = 5772;
	public override uint MessageId { get { return Id; } }

	public long HumanVendorId { get; set; }
	public short HumanVendorCell { get; set; }

	public ExchangeOnHumanVendorRequestMessage() {}


	public ExchangeOnHumanVendorRequestMessage InitExchangeOnHumanVendorRequestMessage(long HumanVendorId, short HumanVendorCell)
	{
		this.HumanVendorId = HumanVendorId;
		this.HumanVendorCell = HumanVendorCell;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.HumanVendorId);
		writer.WriteVarShort(this.HumanVendorCell);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HumanVendorId = reader.ReadVarLong();
		this.HumanVendorCell = reader.ReadVarShort();
	}
}
}
