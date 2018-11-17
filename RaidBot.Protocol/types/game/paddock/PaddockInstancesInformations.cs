using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PaddockInstancesInformations : PaddockInformations
{

	public const uint Id = 509;
	public override uint MessageId { get { return Id; } }

	public PaddockBuyableInformations[] Paddocks { get; set; }

	public PaddockInstancesInformations() {}


	public PaddockInstancesInformations InitPaddockInstancesInformations(PaddockBuyableInformations[] Paddocks)
	{
		this.Paddocks = Paddocks;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.Paddocks.Length);
		foreach (PaddockBuyableInformations item in this.Paddocks)
		{
			writer.WriteShort(item.MessageId);
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		int PaddocksLen = reader.ReadShort();
		Paddocks = new PaddockBuyableInformations[PaddocksLen];
		for (int i = 0; i < PaddocksLen; i++)
		{
			this.Paddocks[i] = ProtocolTypeManager.GetInstance<PaddockBuyableInformations>(reader.ReadShort());
			this.Paddocks[i].Deserialize(reader);
		}
	}
}
}
