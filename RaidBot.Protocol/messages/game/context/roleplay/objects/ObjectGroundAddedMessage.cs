using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectGroundAddedMessage : NetworkMessage
{

	public const uint Id = 3017;
	public override uint MessageId { get { return Id; } }

	public short CellId { get; set; }
	public short ObjectGID { get; set; }

	public ObjectGroundAddedMessage() {}


	public ObjectGroundAddedMessage InitObjectGroundAddedMessage(short CellId, short ObjectGID)
	{
		this.CellId = CellId;
		this.ObjectGID = ObjectGID;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.CellId);
		writer.WriteVarShort(this.ObjectGID);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CellId = reader.ReadVarShort();
		this.ObjectGID = reader.ReadVarShort();
	}
}
}
