using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TaxCollectorStaticInformations : NetworkType
{

	public const uint Id = 147;
	public override uint MessageId { get { return Id; } }

	public short FirstNameId { get; set; }
	public short LastNameId { get; set; }
	public GuildInformations GuildIdentity { get; set; }

	public TaxCollectorStaticInformations() {}


	public TaxCollectorStaticInformations InitTaxCollectorStaticInformations(short FirstNameId, short LastNameId, GuildInformations GuildIdentity)
	{
		this.FirstNameId = FirstNameId;
		this.LastNameId = LastNameId;
		this.GuildIdentity = GuildIdentity;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.FirstNameId);
		writer.WriteVarShort(this.LastNameId);
		this.GuildIdentity.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FirstNameId = reader.ReadVarShort();
		this.LastNameId = reader.ReadVarShort();
		this.GuildIdentity = new GuildInformations();
		this.GuildIdentity.Deserialize(reader);
	}
}
}
