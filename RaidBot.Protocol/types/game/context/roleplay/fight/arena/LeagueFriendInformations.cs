using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LeagueFriendInformations : AbstractContactInformations
{

	public const uint Id = 555;
	public override uint MessageId { get { return Id; } }

	public long PlayerId { get; set; }
	public String PlayerName { get; set; }
	public byte Breed { get; set; }
	public bool Sex { get; set; }
	public short Level { get; set; }
	public short LeagueId { get; set; }
	public short TotalLeaguePoints { get; set; }
	public int LadderPosition { get; set; }

	public LeagueFriendInformations() {}


	public LeagueFriendInformations InitLeagueFriendInformations(long PlayerId, String PlayerName, byte Breed, bool Sex, short Level, short LeagueId, short TotalLeaguePoints, int LadderPosition)
	{
		this.PlayerId = PlayerId;
		this.PlayerName = PlayerName;
		this.Breed = Breed;
		this.Sex = Sex;
		this.Level = Level;
		this.LeagueId = LeagueId;
		this.TotalLeaguePoints = TotalLeaguePoints;
		this.LadderPosition = LadderPosition;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.PlayerId);
		writer.WriteUTF(this.PlayerName);
		writer.WriteByte(this.Breed);
		writer.WriteBoolean(this.Sex);
		writer.WriteVarShort(this.Level);
		writer.WriteVarShort(this.LeagueId);
		writer.WriteVarShort(this.TotalLeaguePoints);
		writer.WriteInt(this.LadderPosition);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.PlayerId = reader.ReadVarLong();
		this.PlayerName = reader.ReadUTF();
		this.Breed = reader.ReadByte();
		this.Sex = reader.ReadBoolean();
		this.Level = reader.ReadVarShort();
		this.LeagueId = reader.ReadVarShort();
		this.TotalLeaguePoints = reader.ReadVarShort();
		this.LadderPosition = reader.ReadInt();
	}
}
}
