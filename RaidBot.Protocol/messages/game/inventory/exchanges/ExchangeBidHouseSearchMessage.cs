using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeBidHouseSearchMessage : NetworkMessage
{

	public const uint Id = 5806;
	public override uint MessageId { get { return Id; } }

	public int Type { get; set; }
	public short GenId { get; set; }

	public ExchangeBidHouseSearchMessage() {}


	public ExchangeBidHouseSearchMessage InitExchangeBidHouseSearchMessage(int Type, short GenId)
	{
		this.Type = Type;
		this.GenId = GenId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.Type);
		writer.WriteVarShort(this.GenId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Type = reader.ReadVarInt();
		this.GenId = reader.ReadVarShort();
	}
}
}
