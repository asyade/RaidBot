using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ChallengeFightJoinRefusedMessage : NetworkMessage
{

	public const uint Id = 5908;
	public override uint MessageId { get { return Id; } }

	public long PlayerId { get; set; }
	public byte Reason { get; set; }

	public ChallengeFightJoinRefusedMessage() {}


	public ChallengeFightJoinRefusedMessage InitChallengeFightJoinRefusedMessage(long PlayerId, byte Reason)
	{
		this.PlayerId = PlayerId;
		this.Reason = Reason;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.PlayerId);
		writer.WriteByte(this.Reason);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PlayerId = reader.ReadVarLong();
		this.Reason = reader.ReadByte();
	}
}
}
