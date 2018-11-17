using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class RoomAvailableUpdateMessage : NetworkMessage
{

	public const uint Id = 6630;
	public override uint MessageId { get { return Id; } }

	public byte NbRoom { get; set; }

	public RoomAvailableUpdateMessage() {}


	public RoomAvailableUpdateMessage InitRoomAvailableUpdateMessage(byte NbRoom)
	{
		this.NbRoom = NbRoom;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.NbRoom);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.NbRoom = reader.ReadByte();
	}
}
}
