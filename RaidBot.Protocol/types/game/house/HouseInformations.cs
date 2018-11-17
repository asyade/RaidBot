using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseInformations : NetworkType
{

	public const uint Id = 111;
	public override uint MessageId { get { return Id; } }

	public int HouseId { get; set; }
	public short ModelId { get; set; }

	public HouseInformations() {}


	public HouseInformations InitHouseInformations(int HouseId, short ModelId)
	{
		this.HouseId = HouseId;
		this.ModelId = ModelId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.HouseId);
		writer.WriteVarShort(this.ModelId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HouseId = reader.ReadVarInt();
		this.ModelId = reader.ReadVarShort();
	}
}
}
