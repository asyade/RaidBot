using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightFighterNamedInformations : GameFightFighterInformations
{

	public const uint Id = 158;
	public override uint MessageId { get { return Id; } }

	public String Name { get; set; }
	public PlayerStatus Status { get; set; }
	public short LeagueId { get; set; }
	public int LadderPosition { get; set; }
	public bool HiddenInPrefight { get; set; }

	public GameFightFighterNamedInformations() {}


	public GameFightFighterNamedInformations InitGameFightFighterNamedInformations(String Name, PlayerStatus Status, short LeagueId, int LadderPosition, bool HiddenInPrefight)
	{
		this.Name = Name;
		this.Status = Status;
		this.LeagueId = LeagueId;
		this.LadderPosition = LadderPosition;
		this.HiddenInPrefight = HiddenInPrefight;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.Name);
		this.Status.Serialize(writer);
		writer.WriteVarShort(this.LeagueId);
		writer.WriteInt(this.LadderPosition);
		writer.WriteBoolean(this.HiddenInPrefight);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Name = reader.ReadUTF();
		this.Status = new PlayerStatus();
		this.Status.Deserialize(reader);
		this.LeagueId = reader.ReadVarShort();
		this.LadderPosition = reader.ReadInt();
		this.HiddenInPrefight = reader.ReadBoolean();
	}
}
}
