using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameDataPaddockObjectRemoveMessage : NetworkMessage
{

	public const uint Id = 5993;
	public override uint MessageId { get { return Id; } }

	public short CellId { get; set; }

	public GameDataPaddockObjectRemoveMessage() {}


	public GameDataPaddockObjectRemoveMessage InitGameDataPaddockObjectRemoveMessage(short CellId)
	{
		this.CellId = CellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.CellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CellId = reader.ReadVarShort();
	}
}
}
