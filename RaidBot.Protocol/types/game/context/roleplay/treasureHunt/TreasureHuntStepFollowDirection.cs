using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TreasureHuntStepFollowDirection : TreasureHuntStep
{

	public const uint Id = 468;
	public override uint MessageId { get { return Id; } }

	public byte Direction { get; set; }
	public short MapCount { get; set; }

	public TreasureHuntStepFollowDirection() {}


	public TreasureHuntStepFollowDirection InitTreasureHuntStepFollowDirection(byte Direction, short MapCount)
	{
		this.Direction = Direction;
		this.MapCount = MapCount;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.Direction);
		writer.WriteVarShort(this.MapCount);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Direction = reader.ReadByte();
		this.MapCount = reader.ReadVarShort();
	}
}
}
