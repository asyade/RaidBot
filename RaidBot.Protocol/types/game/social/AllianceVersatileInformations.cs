using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AllianceVersatileInformations : NetworkType
{

	public const uint Id = 432;
	public override uint MessageId { get { return Id; } }

	public int AllianceId { get; set; }
	public short NbGuilds { get; set; }
	public short NbMembers { get; set; }
	public short NbSubarea { get; set; }

	public AllianceVersatileInformations() {}


	public AllianceVersatileInformations InitAllianceVersatileInformations(int AllianceId, short NbGuilds, short NbMembers, short NbSubarea)
	{
		this.AllianceId = AllianceId;
		this.NbGuilds = NbGuilds;
		this.NbMembers = NbMembers;
		this.NbSubarea = NbSubarea;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.AllianceId);
		writer.WriteVarShort(this.NbGuilds);
		writer.WriteVarShort(this.NbMembers);
		writer.WriteVarShort(this.NbSubarea);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AllianceId = reader.ReadVarInt();
		this.NbGuilds = reader.ReadVarShort();
		this.NbMembers = reader.ReadVarShort();
		this.NbSubarea = reader.ReadVarShort();
	}
}
}
