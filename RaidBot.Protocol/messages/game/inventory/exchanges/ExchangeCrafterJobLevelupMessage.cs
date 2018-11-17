using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeCrafterJobLevelupMessage : NetworkMessage
{

	public const uint Id = 6598;
	public override uint MessageId { get { return Id; } }

	public byte CrafterJobLevel { get; set; }

	public ExchangeCrafterJobLevelupMessage() {}


	public ExchangeCrafterJobLevelupMessage InitExchangeCrafterJobLevelupMessage(byte CrafterJobLevel)
	{
		this.CrafterJobLevel = CrafterJobLevel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.CrafterJobLevel);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CrafterJobLevel = reader.ReadByte();
	}
}
}
