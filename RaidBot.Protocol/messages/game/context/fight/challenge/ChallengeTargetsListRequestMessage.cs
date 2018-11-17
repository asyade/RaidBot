using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ChallengeTargetsListRequestMessage : NetworkMessage
{

	public const uint Id = 5614;
	public override uint MessageId { get { return Id; } }

	public short ChallengeId { get; set; }

	public ChallengeTargetsListRequestMessage() {}


	public ChallengeTargetsListRequestMessage InitChallengeTargetsListRequestMessage(short ChallengeId)
	{
		this.ChallengeId = ChallengeId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ChallengeId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ChallengeId = reader.ReadVarShort();
	}
}
}
