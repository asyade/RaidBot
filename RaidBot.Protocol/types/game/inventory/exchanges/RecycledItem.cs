using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class RecycledItem : NetworkType
{

	public const uint Id = 547;
	public override uint MessageId { get { return Id; } }

	public short Id_ { get; set; }
	public uint Qty { get; set; }

	public RecycledItem() {}


	public RecycledItem InitRecycledItem(short Id_, uint Qty)
	{
		this.Id_ = Id_;
		this.Qty = Qty;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.Id_);
		writer.WriteUnsignedInt(this.Qty);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadVarShort();
		this.Qty = reader.ReadUnsignedInt();
	}
}
}
