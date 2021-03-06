using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeCraftCountModifiedMessage : NetworkMessage
{

	public const uint Id = 6595;
	public override uint MessageId { get { return Id; } }

	public int Count { get; set; }

	public ExchangeCraftCountModifiedMessage() {}


	public ExchangeCraftCountModifiedMessage InitExchangeCraftCountModifiedMessage(int Count)
	{
		this.Count = Count;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.Count);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Count = reader.ReadVarInt();
	}
}
}
