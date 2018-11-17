using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class UpdateMountCharacteristicsMessage : NetworkMessage
{

	public const uint Id = 6753;
	public override uint MessageId { get { return Id; } }

	public int RideId { get; set; }
	public UpdateMountCharacteristic[] BoostToUpdateList { get; set; }

	public UpdateMountCharacteristicsMessage() {}


	public UpdateMountCharacteristicsMessage InitUpdateMountCharacteristicsMessage(int RideId, UpdateMountCharacteristic[] BoostToUpdateList)
	{
		this.RideId = RideId;
		this.BoostToUpdateList = BoostToUpdateList;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.RideId);
		writer.WriteShort(this.BoostToUpdateList.Length);
		foreach (UpdateMountCharacteristic item in this.BoostToUpdateList)
		{
			writer.WriteShort(item.MessageId);
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.RideId = reader.ReadVarInt();
		int BoostToUpdateListLen = reader.ReadShort();
		BoostToUpdateList = new UpdateMountCharacteristic[BoostToUpdateListLen];
		for (int i = 0; i < BoostToUpdateListLen; i++)
		{
			this.BoostToUpdateList[i] = ProtocolTypeManager.GetInstance<UpdateMountCharacteristic>(reader.ReadShort());
			this.BoostToUpdateList[i].Deserialize(reader);
		}
	}
}
}
