using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HousePropertiesMessage : NetworkMessage
{

	public const uint Id = 5734;
	public override uint MessageId { get { return Id; } }

	public int HouseId { get; set; }
	public int[] DoorsOnMap { get; set; }

	public HousePropertiesMessage() {}


	public HousePropertiesMessage InitHousePropertiesMessage(int HouseId, int[] DoorsOnMap)
	{
		this.HouseId = HouseId;
		this.DoorsOnMap = DoorsOnMap;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.HouseId);
		writer.WriteShort(this.DoorsOnMap.Length);
		foreach (int item in this.DoorsOnMap)
		{
			writer.WriteInt(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HouseId = reader.ReadVarInt();
		int DoorsOnMapLen = reader.ReadShort();
		DoorsOnMap = new int[DoorsOnMapLen];
		for (int i = 0; i < DoorsOnMapLen; i++)
		{
			this.DoorsOnMap[i] = reader.ReadInt();
		}
	}
}
}
