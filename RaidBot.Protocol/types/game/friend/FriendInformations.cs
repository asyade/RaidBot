using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FriendInformations : AbstractContactInformations
{

	public const uint Id = 78;
	public override uint MessageId { get { return Id; } }

	public byte PlayerState { get; set; }
	public short LastConnection { get; set; }
	public int AchievementPoints { get; set; }
	public short LeagueId { get; set; }
	public int LadderPosition { get; set; }

	public FriendInformations() {}


	public FriendInformations InitFriendInformations(byte PlayerState, short LastConnection, int AchievementPoints, short LeagueId, int LadderPosition)
	{
		this.PlayerState = PlayerState;
		this.LastConnection = LastConnection;
		this.AchievementPoints = AchievementPoints;
		this.LeagueId = LeagueId;
		this.LadderPosition = LadderPosition;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.PlayerState);
		writer.WriteVarShort(this.LastConnection);
		writer.WriteInt(this.AchievementPoints);
		writer.WriteVarShort(this.LeagueId);
		writer.WriteInt(this.LadderPosition);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.PlayerState = reader.ReadByte();
		this.LastConnection = reader.ReadVarShort();
		this.AchievementPoints = reader.ReadInt();
		this.LeagueId = reader.ReadVarShort();
		this.LadderPosition = reader.ReadInt();
	}
}
}
