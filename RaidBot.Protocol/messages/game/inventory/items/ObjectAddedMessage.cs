using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectAddedMessage : NetworkMessage
{

	public const uint Id = 3025;
	public override uint MessageId { get { return Id; } }

	public ObjectItem Object { get; set; }
	public byte Origin { get; set; }

	public ObjectAddedMessage() {}


	public ObjectAddedMessage InitObjectAddedMessage(ObjectItem Object, byte Origin)
	{
		this.Object = Object;
		this.Origin = Origin;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Object.Serialize(writer);
		writer.WriteByte(this.Origin);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Object = new ObjectItem();
		this.Object.Deserialize(reader);
		this.Origin = reader.ReadByte();
	}
}
}
