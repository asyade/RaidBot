using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TaxCollectorWaitingForHelpInformations : TaxCollectorComplementaryInformations
{

	public const uint Id = 447;
	public override uint MessageId { get { return Id; } }

	public ProtectedEntityWaitingForHelpInfo WaitingForHelpInfo { get; set; }

	public TaxCollectorWaitingForHelpInformations() {}


	public TaxCollectorWaitingForHelpInformations InitTaxCollectorWaitingForHelpInformations(ProtectedEntityWaitingForHelpInfo WaitingForHelpInfo)
	{
		this.WaitingForHelpInfo = WaitingForHelpInfo;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.WaitingForHelpInfo.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.WaitingForHelpInfo = new ProtectedEntityWaitingForHelpInfo();
		this.WaitingForHelpInfo.Deserialize(reader);
	}
}
}
