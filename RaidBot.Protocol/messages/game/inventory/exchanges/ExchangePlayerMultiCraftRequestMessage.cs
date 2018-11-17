using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangePlayerMultiCraftRequestMessage : ExchangeRequestMessage
{

	public const uint Id = 5784;
	public override uint MessageId { get { return Id; } }

	public long Target { get; set; }
	public int SkillId { get; set; }

	public ExchangePlayerMultiCraftRequestMessage() {}


	public ExchangePlayerMultiCraftRequestMessage InitExchangePlayerMultiCraftRequestMessage(long Target, int SkillId)
	{
		this.Target = Target;
		this.SkillId = SkillId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.Target);
		writer.WriteVarInt(this.SkillId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Target = reader.ReadVarLong();
		this.SkillId = reader.ReadVarInt();
	}
}
}
