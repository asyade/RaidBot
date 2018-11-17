using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TaxCollectorStaticExtendedInformations : TaxCollectorStaticInformations
{

	public const uint Id = 440;
	public override uint MessageId { get { return Id; } }

	public AllianceInformations AllianceIdentity { get; set; }

	public TaxCollectorStaticExtendedInformations() {}


	public TaxCollectorStaticExtendedInformations InitTaxCollectorStaticExtendedInformations(AllianceInformations AllianceIdentity)
	{
		this.AllianceIdentity = AllianceIdentity;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.AllianceIdentity.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.AllianceIdentity = new AllianceInformations();
		this.AllianceIdentity.Deserialize(reader);
	}
}
}
