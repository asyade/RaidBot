using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DareRewardWonMessage : NetworkMessage
{

	public const uint Id = 6678;
	public override uint MessageId { get { return Id; } }

	public DareReward Reward { get; set; }

	public DareRewardWonMessage() {}


	public DareRewardWonMessage InitDareRewardWonMessage(DareReward Reward)
	{
		this.Reward = Reward;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Reward.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Reward = new DareReward();
		this.Reward.Deserialize(reader);
	}
}
}
