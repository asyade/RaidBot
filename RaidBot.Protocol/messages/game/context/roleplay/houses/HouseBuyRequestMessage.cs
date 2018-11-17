using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseBuyRequestMessage : NetworkMessage
{

	public const uint Id = 5738;
	public override uint MessageId { get { return Id; } }

	public long ProposedPrice { get; set; }

	public HouseBuyRequestMessage() {}


	public HouseBuyRequestMessage InitHouseBuyRequestMessage(long ProposedPrice)
	{
		this.ProposedPrice = ProposedPrice;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.ProposedPrice);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ProposedPrice = reader.ReadVarLong();
	}
}
}
