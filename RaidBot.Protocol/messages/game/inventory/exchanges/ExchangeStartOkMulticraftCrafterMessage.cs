using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeStartOkMulticraftCrafterMessage : NetworkMessage
{

	public const uint Id = 5818;
	public override uint MessageId { get { return Id; } }

	public int SkillId { get; set; }

	public ExchangeStartOkMulticraftCrafterMessage() {}


	public ExchangeStartOkMulticraftCrafterMessage InitExchangeStartOkMulticraftCrafterMessage(int SkillId)
	{
		this.SkillId = SkillId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.SkillId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SkillId = reader.ReadVarInt();
	}
}
}
