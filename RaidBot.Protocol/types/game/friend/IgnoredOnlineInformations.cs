using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class IgnoredOnlineInformations : IgnoredInformations
{

	public const uint Id = 105;
	public override uint MessageId { get { return Id; } }

	public long PlayerId { get; set; }
	public String PlayerName { get; set; }
	public byte Breed { get; set; }
	public bool Sex { get; set; }

	public IgnoredOnlineInformations() {}


	public IgnoredOnlineInformations InitIgnoredOnlineInformations(long PlayerId, String PlayerName, byte Breed, bool Sex)
	{
		this.PlayerId = PlayerId;
		this.PlayerName = PlayerName;
		this.Breed = Breed;
		this.Sex = Sex;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.PlayerId);
		writer.WriteUTF(this.PlayerName);
		writer.WriteByte(this.Breed);
		writer.WriteBoolean(this.Sex);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.PlayerId = reader.ReadVarLong();
		this.PlayerName = reader.ReadUTF();
		this.Breed = reader.ReadByte();
		this.Sex = reader.ReadBoolean();
	}
}
}
