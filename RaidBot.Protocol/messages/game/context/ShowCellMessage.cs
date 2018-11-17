using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ShowCellMessage : NetworkMessage
{

	public const uint Id = 5612;
	public override uint MessageId { get { return Id; } }

	public double SourceId { get; set; }
	public short CellId { get; set; }

	public ShowCellMessage() {}


	public ShowCellMessage InitShowCellMessage(double SourceId, short CellId)
	{
		this.SourceId = SourceId;
		this.CellId = CellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.SourceId);
		writer.WriteVarShort(this.CellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SourceId = reader.ReadDouble();
		this.CellId = reader.ReadVarShort();
	}
}
}
