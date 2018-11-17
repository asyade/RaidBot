using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ChallengeResultMessage : NetworkMessage
{

	public const uint Id = 6019;
	public override uint MessageId { get { return Id; } }

	public short ChallengeId { get; set; }
	public bool Success { get; set; }

	public ChallengeResultMessage() {}


	public ChallengeResultMessage InitChallengeResultMessage(short ChallengeId, bool Success)
	{
		this.ChallengeId = ChallengeId;
		this.Success = Success;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ChallengeId);
		writer.WriteBoolean(this.Success);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ChallengeId = reader.ReadVarShort();
		this.Success = reader.ReadBoolean();
	}
}
}
