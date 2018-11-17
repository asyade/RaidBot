using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeStartOkMulticraftCustomerMessage : NetworkMessage
{

	public const uint Id = 5817;
	public override uint MessageId { get { return Id; } }

	public int SkillId { get; set; }
	public byte CrafterJobLevel { get; set; }

	public ExchangeStartOkMulticraftCustomerMessage() {}


	public ExchangeStartOkMulticraftCustomerMessage InitExchangeStartOkMulticraftCustomerMessage(int SkillId, byte CrafterJobLevel)
	{
		this.SkillId = SkillId;
		this.CrafterJobLevel = CrafterJobLevel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.SkillId);
		writer.WriteByte(this.CrafterJobLevel);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SkillId = reader.ReadVarInt();
		this.CrafterJobLevel = reader.ReadByte();
	}
}
}
