using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildVersatileInformations : NetworkType
{

	public const uint Id = 435;
	public override uint MessageId { get { return Id; } }

	public int GuildId { get; set; }
	public long LeaderId { get; set; }
	public byte GuildLevel { get; set; }
	public byte NbMembers { get; set; }

	public GuildVersatileInformations() {}


	public GuildVersatileInformations InitGuildVersatileInformations(int GuildId, long LeaderId, byte GuildLevel, byte NbMembers)
	{
		this.GuildId = GuildId;
		this.LeaderId = LeaderId;
		this.GuildLevel = GuildLevel;
		this.NbMembers = NbMembers;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.GuildId);
		writer.WriteVarLong(this.LeaderId);
		writer.WriteByte(this.GuildLevel);
		writer.WriteByte(this.NbMembers);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.GuildId = reader.ReadVarInt();
		this.LeaderId = reader.ReadVarLong();
		this.GuildLevel = reader.ReadByte();
		this.NbMembers = reader.ReadByte();
	}
}
}
