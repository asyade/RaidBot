using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeStartOkCraftWithInformationMessage : ExchangeStartOkCraftMessage
{

	public const uint Id = 5941;
	public override uint MessageId { get { return Id; } }

	public int SkillId { get; set; }

	public ExchangeStartOkCraftWithInformationMessage() {}


	public ExchangeStartOkCraftWithInformationMessage InitExchangeStartOkCraftWithInformationMessage(int SkillId)
	{
		this.SkillId = SkillId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.SkillId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.SkillId = reader.ReadVarInt();
	}
}
}
