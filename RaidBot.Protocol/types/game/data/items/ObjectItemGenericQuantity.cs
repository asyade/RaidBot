using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectItemGenericQuantity : Item
{

	public const uint Id = 483;
	public override uint MessageId { get { return Id; } }

	public short ObjectGID { get; set; }
	public int Quantity { get; set; }

	public ObjectItemGenericQuantity() {}


	public ObjectItemGenericQuantity InitObjectItemGenericQuantity(short ObjectGID, int Quantity)
	{
		this.ObjectGID = ObjectGID;
		this.Quantity = Quantity;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.ObjectGID);
		writer.WriteVarInt(this.Quantity);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.ObjectGID = reader.ReadVarShort();
		this.Quantity = reader.ReadVarInt();
	}
}
}
