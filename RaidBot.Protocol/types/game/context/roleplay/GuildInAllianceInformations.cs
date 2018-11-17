using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildInAllianceInformations : GuildInformations
{

	public const uint Id = 420;
	public override uint MessageId { get { return Id; } }

	public byte NbMembers { get; set; }
	public int JoinDate { get; set; }

	public GuildInAllianceInformations() {}


	public GuildInAllianceInformations InitGuildInAllianceInformations(byte NbMembers, int JoinDate)
	{
		this.NbMembers = NbMembers;
		this.JoinDate = JoinDate;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.NbMembers);
		writer.WriteInt(this.JoinDate);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.NbMembers = reader.ReadByte();
		this.JoinDate = reader.ReadInt();
	}
}
}
