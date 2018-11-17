using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AdditionalTaxCollectorInformations : NetworkType
{

	public const uint Id = 165;
	public override uint MessageId { get { return Id; } }

	public String CollectorCallerName { get; set; }
	public int Date { get; set; }

	public AdditionalTaxCollectorInformations() {}


	public AdditionalTaxCollectorInformations InitAdditionalTaxCollectorInformations(String CollectorCallerName, int Date)
	{
		this.CollectorCallerName = CollectorCallerName;
		this.Date = Date;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.CollectorCallerName);
		writer.WriteInt(this.Date);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CollectorCallerName = reader.ReadUTF();
		this.Date = reader.ReadInt();
	}
}
}
