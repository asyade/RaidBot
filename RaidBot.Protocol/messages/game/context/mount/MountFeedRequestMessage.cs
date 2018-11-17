using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MountFeedRequestMessage : NetworkMessage
{

	public const uint Id = 6189;
	public override uint MessageId { get { return Id; } }

	public int MountUid { get; set; }
	public byte MountLocation { get; set; }
	public int MountFoodUid { get; set; }
	public int Quantity { get; set; }

	public MountFeedRequestMessage() {}


	public MountFeedRequestMessage InitMountFeedRequestMessage(int MountUid, byte MountLocation, int MountFoodUid, int Quantity)
	{
		this.MountUid = MountUid;
		this.MountLocation = MountLocation;
		this.MountFoodUid = MountFoodUid;
		this.Quantity = Quantity;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.MountUid);
		writer.WriteByte(this.MountLocation);
		writer.WriteVarInt(this.MountFoodUid);
		writer.WriteVarInt(this.Quantity);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MountUid = reader.ReadVarInt();
		this.MountLocation = reader.ReadByte();
		this.MountFoodUid = reader.ReadVarInt();
		this.Quantity = reader.ReadVarInt();
	}
}
}
