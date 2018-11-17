using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TreasureHuntStepFollowDirectionToPOI : TreasureHuntStep
{

	public const uint Id = 461;
	public override uint MessageId { get { return Id; } }

	public byte Direction { get; set; }
	public short PoiLabelId { get; set; }

	public TreasureHuntStepFollowDirectionToPOI() {}


	public TreasureHuntStepFollowDirectionToPOI InitTreasureHuntStepFollowDirectionToPOI(byte Direction, short PoiLabelId)
	{
		this.Direction = Direction;
		this.PoiLabelId = PoiLabelId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.Direction);
		writer.WriteVarShort(this.PoiLabelId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Direction = reader.ReadByte();
		this.PoiLabelId = reader.ReadVarShort();
	}
}
}
