using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectUseOnCellMessage : ObjectUseMessage
{

	public const uint Id = 3013;
	public override uint MessageId { get { return Id; } }

	public short Cells { get; set; }

	public ObjectUseOnCellMessage() {}


	public ObjectUseOnCellMessage InitObjectUseOnCellMessage(short Cells)
	{
		this.Cells = Cells;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.Cells);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Cells = reader.ReadVarShort();
	}
}
}
