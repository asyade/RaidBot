using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectGroundRemovedMessage : NetworkMessage
{

	public const uint Id = 3014;
	public override uint MessageId { get { return Id; } }

	public short Cell { get; set; }

	public ObjectGroundRemovedMessage() {}


	public ObjectGroundRemovedMessage InitObjectGroundRemovedMessage(short Cell)
	{
		this.Cell = Cell;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.Cell);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Cell = reader.ReadVarShort();
	}
}
}
