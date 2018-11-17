using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeCraftResultMessage : NetworkMessage
{

	public const uint Id = 5790;
	public override uint MessageId { get { return Id; } }

	public byte CraftResult { get; set; }

	public ExchangeCraftResultMessage() {}


	public ExchangeCraftResultMessage InitExchangeCraftResultMessage(byte CraftResult)
	{
		this.CraftResult = CraftResult;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.CraftResult);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CraftResult = reader.ReadByte();
	}
}
}
