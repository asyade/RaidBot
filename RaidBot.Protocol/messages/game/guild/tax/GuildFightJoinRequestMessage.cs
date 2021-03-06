using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildFightJoinRequestMessage : NetworkMessage
{

	public const uint Id = 5717;
	public override uint MessageId { get { return Id; } }

	public double TaxCollectorId { get; set; }

	public GuildFightJoinRequestMessage() {}


	public GuildFightJoinRequestMessage InitGuildFightJoinRequestMessage(double TaxCollectorId)
	{
		this.TaxCollectorId = TaxCollectorId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.TaxCollectorId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.TaxCollectorId = reader.ReadDouble();
	}
}
}
