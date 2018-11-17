using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildFactSheetInformations : GuildInformations
{

	public const uint Id = 424;
	public override uint MessageId { get { return Id; } }

	public long LeaderId { get; set; }
	public short NbMembers { get; set; }

	public GuildFactSheetInformations() {}


	public GuildFactSheetInformations InitGuildFactSheetInformations(long LeaderId, short NbMembers)
	{
		this.LeaderId = LeaderId;
		this.NbMembers = NbMembers;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.LeaderId);
		writer.WriteVarShort(this.NbMembers);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.LeaderId = reader.ReadVarLong();
		this.NbMembers = reader.ReadVarShort();
	}
}
}
