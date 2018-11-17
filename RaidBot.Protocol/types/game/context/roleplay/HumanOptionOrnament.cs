using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HumanOptionOrnament : HumanOption
{

	public const uint Id = 411;
	public override uint MessageId { get { return Id; } }

	public short OrnamentId { get; set; }
	public short Level { get; set; }
	public short LeagueId { get; set; }
	public int LadderPosition { get; set; }

	public HumanOptionOrnament() {}


	public HumanOptionOrnament InitHumanOptionOrnament(short OrnamentId, short Level, short LeagueId, int LadderPosition)
	{
		this.OrnamentId = OrnamentId;
		this.Level = Level;
		this.LeagueId = LeagueId;
		this.LadderPosition = LadderPosition;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.OrnamentId);
		writer.WriteVarShort(this.Level);
		writer.WriteVarShort(this.LeagueId);
		writer.WriteInt(this.LadderPosition);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.OrnamentId = reader.ReadVarShort();
		this.Level = reader.ReadVarShort();
		this.LeagueId = reader.ReadVarShort();
		this.LadderPosition = reader.ReadInt();
	}
}
}
