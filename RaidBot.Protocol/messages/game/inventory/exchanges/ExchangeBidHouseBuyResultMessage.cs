using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeBidHouseBuyResultMessage : NetworkMessage
{

	public const uint Id = 6272;
	public override uint MessageId { get { return Id; } }

	public int Uid { get; set; }
	public bool Bought { get; set; }

	public ExchangeBidHouseBuyResultMessage() {}


	public ExchangeBidHouseBuyResultMessage InitExchangeBidHouseBuyResultMessage(int Uid, bool Bought)
	{
		this.Uid = Uid;
		this.Bought = Bought;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.Uid);
		writer.WriteBoolean(this.Bought);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Uid = reader.ReadVarInt();
		this.Bought = reader.ReadBoolean();
	}
}
}
