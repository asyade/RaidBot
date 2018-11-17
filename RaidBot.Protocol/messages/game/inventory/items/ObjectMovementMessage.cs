using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectMovementMessage : NetworkMessage
{

	public const uint Id = 3010;
	public override uint MessageId { get { return Id; } }

	public int ObjectUID { get; set; }
	public short Position { get; set; }

	public ObjectMovementMessage() {}


	public ObjectMovementMessage InitObjectMovementMessage(int ObjectUID, short Position)
	{
		this.ObjectUID = ObjectUID;
		this.Position = Position;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.ObjectUID);
		writer.WriteShort(this.Position);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ObjectUID = reader.ReadVarInt();
		this.Position = reader.ReadShort();
	}
}
}
