using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AtlasPointsInformations : NetworkType
{

	public const uint Id = 175;
	public override uint MessageId { get { return Id; } }

	public byte Type { get; set; }
	public MapCoordinatesExtended[] Coords { get; set; }

	public AtlasPointsInformations() {}


	public AtlasPointsInformations InitAtlasPointsInformations(byte Type, MapCoordinatesExtended[] Coords)
	{
		this.Type = Type;
		this.Coords = Coords;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Type);
		writer.WriteShort(this.Coords.Length);
		foreach (MapCoordinatesExtended item in this.Coords)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Type = reader.ReadByte();
		int CoordsLen = reader.ReadShort();
		Coords = new MapCoordinatesExtended[CoordsLen];
		for (int i = 0; i < CoordsLen; i++)
		{
			this.Coords[i] = new MapCoordinatesExtended();
			this.Coords[i].Deserialize(reader);
		}
	}
}
}
