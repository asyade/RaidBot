using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MapCoordinatesExtended : MapCoordinatesAndId
{

	public const uint Id = 176;
	public override uint MessageId { get { return Id; } }

	public short SubAreaId { get; set; }

	public MapCoordinatesExtended() {}


	public MapCoordinatesExtended InitMapCoordinatesExtended(short SubAreaId)
	{
		this.SubAreaId = SubAreaId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.SubAreaId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.SubAreaId = reader.ReadVarShort();
	}
}
}
