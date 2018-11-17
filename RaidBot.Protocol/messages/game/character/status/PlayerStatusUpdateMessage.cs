using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PlayerStatusUpdateMessage : NetworkMessage
{

	public const uint Id = 6386;
	public override uint MessageId { get { return Id; } }

	public int AccountId { get; set; }
	public long PlayerId { get; set; }

	public PlayerStatusUpdateMessage() {}


	public PlayerStatusUpdateMessage InitPlayerStatusUpdateMessage(int AccountId, long PlayerId)
	{
		this.AccountId = AccountId;
		this.PlayerId = PlayerId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.AccountId);
		writer.WriteVarLong(this.PlayerId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AccountId = reader.ReadInt();
		this.PlayerId = reader.ReadVarLong();
	}
}
}
