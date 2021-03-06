using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AlliancePrismInformation : PrismInformation
{

	public const uint Id = 427;
	public override uint MessageId { get { return Id; } }

	public AllianceInformations Alliance { get; set; }

	public AlliancePrismInformation() {}


	public AlliancePrismInformation InitAlliancePrismInformation(AllianceInformations Alliance)
	{
		this.Alliance = Alliance;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.Alliance.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Alliance = new AllianceInformations();
		this.Alliance.Deserialize(reader);
	}
}
}
