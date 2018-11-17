using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AccountInformationsUpdateMessage : NetworkMessage
{

	public const uint Id = 6740;
	public override uint MessageId { get { return Id; } }

	public double SubscriptionEndDate { get; set; }
	public double UnlimitedRestatEndDate { get; set; }

	public AccountInformationsUpdateMessage() {}


	public AccountInformationsUpdateMessage InitAccountInformationsUpdateMessage(double SubscriptionEndDate, double UnlimitedRestatEndDate)
	{
		this.SubscriptionEndDate = SubscriptionEndDate;
		this.UnlimitedRestatEndDate = UnlimitedRestatEndDate;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.SubscriptionEndDate);
		writer.WriteDouble(this.UnlimitedRestatEndDate);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SubscriptionEndDate = reader.ReadDouble();
		this.UnlimitedRestatEndDate = reader.ReadDouble();
	}
}
}
