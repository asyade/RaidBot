using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ChallengeTargetUpdateMessage : NetworkMessage
{

	public const uint Id = 6123;
	public override uint MessageId { get { return Id; } }

	public short ChallengeId { get; set; }
	public double TargetId { get; set; }

	public ChallengeTargetUpdateMessage() {}


	public ChallengeTargetUpdateMessage InitChallengeTargetUpdateMessage(short ChallengeId, double TargetId)
	{
		this.ChallengeId = ChallengeId;
		this.TargetId = TargetId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ChallengeId);
		writer.WriteDouble(this.TargetId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ChallengeId = reader.ReadVarShort();
		this.TargetId = reader.ReadDouble();
	}
}
}
