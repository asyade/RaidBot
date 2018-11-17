using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeOkMultiCraftMessage : NetworkMessage
{

	public const uint Id = 5768;
	public override uint MessageId { get { return Id; } }

	public long InitiatorId { get; set; }
	public long OtherId { get; set; }
	public byte Role { get; set; }

	public ExchangeOkMultiCraftMessage() {}


	public ExchangeOkMultiCraftMessage InitExchangeOkMultiCraftMessage(long InitiatorId, long OtherId, byte Role)
	{
		this.InitiatorId = InitiatorId;
		this.OtherId = OtherId;
		this.Role = Role;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.InitiatorId);
		writer.WriteVarLong(this.OtherId);
		writer.WriteByte(this.Role);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.InitiatorId = reader.ReadVarLong();
		this.OtherId = reader.ReadVarLong();
		this.Role = reader.ReadByte();
	}
}
}
