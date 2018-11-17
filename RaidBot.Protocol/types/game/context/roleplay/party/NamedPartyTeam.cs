using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class NamedPartyTeam : NetworkType
{

	public const uint Id = 469;
	public override uint MessageId { get { return Id; } }

	public byte TeamId { get; set; }
	public String PartyName { get; set; }

	public NamedPartyTeam() {}


	public NamedPartyTeam InitNamedPartyTeam(byte TeamId, String PartyName)
	{
		this.TeamId = TeamId;
		this.PartyName = PartyName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.TeamId);
		writer.WriteUTF(this.PartyName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.TeamId = reader.ReadByte();
		this.PartyName = reader.ReadUTF();
	}
}
}
