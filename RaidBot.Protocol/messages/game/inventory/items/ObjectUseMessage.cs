using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectUseMessage : NetworkMessage
{

	public const uint Id = 3019;
	public override uint MessageId { get { return Id; } }

	public int ObjectUID { get; set; }

	public ObjectUseMessage() {}


	public ObjectUseMessage InitObjectUseMessage(int ObjectUID)
	{
		this.ObjectUID = ObjectUID;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.ObjectUID);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ObjectUID = reader.ReadVarInt();
	}
}
}
