using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class NumericWhoIsMessage : NetworkMessage
{

	public const uint Id = 6297;
	public override uint MessageId { get { return Id; } }

	public long PlayerId { get; set; }
	public int AccountId { get; set; }

	public NumericWhoIsMessage() {}


	public NumericWhoIsMessage InitNumericWhoIsMessage(long PlayerId, int AccountId)
	{
		this.PlayerId = PlayerId;
		this.AccountId = AccountId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.PlayerId);
		writer.WriteInt(this.AccountId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PlayerId = reader.ReadVarLong();
		this.AccountId = reader.ReadInt();
	}
}
}
