using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PaddockMoveItemRequestMessage : NetworkMessage
{

	public const uint Id = 6052;
	public override uint MessageId { get { return Id; } }

	public short OldCellId { get; set; }
	public short NewCellId { get; set; }

	public PaddockMoveItemRequestMessage() {}


	public PaddockMoveItemRequestMessage InitPaddockMoveItemRequestMessage(short OldCellId, short NewCellId)
	{
		this.OldCellId = OldCellId;
		this.NewCellId = NewCellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.OldCellId);
		writer.WriteVarShort(this.NewCellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.OldCellId = reader.ReadVarShort();
		this.NewCellId = reader.ReadVarShort();
	}
}
}
