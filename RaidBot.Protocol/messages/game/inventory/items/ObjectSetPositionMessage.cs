using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectSetPositionMessage : NetworkMessage
{

	public const uint Id = 3021;
	public override uint MessageId { get { return Id; } }

	public int ObjectUID { get; set; }
	public short Position { get; set; }
	public int Quantity { get; set; }

	public ObjectSetPositionMessage() {}


	public ObjectSetPositionMessage InitObjectSetPositionMessage(int ObjectUID, short Position, int Quantity)
	{
		this.ObjectUID = ObjectUID;
		this.Position = Position;
		this.Quantity = Quantity;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.ObjectUID);
		writer.WriteShort(this.Position);
		writer.WriteVarInt(this.Quantity);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ObjectUID = reader.ReadVarInt();
		this.Position = reader.ReadShort();
		this.Quantity = reader.ReadVarInt();
	}
}
}
