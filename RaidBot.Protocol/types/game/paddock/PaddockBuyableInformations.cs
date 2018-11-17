using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PaddockBuyableInformations : NetworkType
{

	public const uint Id = 130;
	public override uint MessageId { get { return Id; } }

	public long Price { get; set; }
	public bool Locked { get; set; }

	public PaddockBuyableInformations() {}


	public PaddockBuyableInformations InitPaddockBuyableInformations(long Price, bool Locked)
	{
		this.Price = Price;
		this.Locked = Locked;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.Price);
		writer.WriteBoolean(this.Locked);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Price = reader.ReadVarLong();
		this.Locked = reader.ReadBoolean();
	}
}
}
