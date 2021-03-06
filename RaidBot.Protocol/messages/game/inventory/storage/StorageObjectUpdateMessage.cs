using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class StorageObjectUpdateMessage : NetworkMessage
{

	public const uint Id = 5647;
	public override uint MessageId { get { return Id; } }

	public ObjectItem Object { get; set; }

	public StorageObjectUpdateMessage() {}


	public StorageObjectUpdateMessage InitStorageObjectUpdateMessage(ObjectItem Object)
	{
		this.Object = Object;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Object.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Object = new ObjectItem();
		this.Object.Deserialize(reader);
	}
}
}
