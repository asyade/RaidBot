using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeBidHouseGenericItemRemovedMessage : NetworkMessage
{

	public const uint Id = 5948;
	public override uint MessageId { get { return Id; } }

	public short ObjGenericId { get; set; }

	public ExchangeBidHouseGenericItemRemovedMessage() {}


	public ExchangeBidHouseGenericItemRemovedMessage InitExchangeBidHouseGenericItemRemovedMessage(short ObjGenericId)
	{
		this.ObjGenericId = ObjGenericId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ObjGenericId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ObjGenericId = reader.ReadVarShort();
	}
}
}
