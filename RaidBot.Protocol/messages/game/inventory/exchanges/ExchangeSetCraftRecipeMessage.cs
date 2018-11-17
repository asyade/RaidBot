using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeSetCraftRecipeMessage : NetworkMessage
{

	public const uint Id = 6389;
	public override uint MessageId { get { return Id; } }

	public short ObjectGID { get; set; }

	public ExchangeSetCraftRecipeMessage() {}


	public ExchangeSetCraftRecipeMessage InitExchangeSetCraftRecipeMessage(short ObjectGID)
	{
		this.ObjectGID = ObjectGID;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ObjectGID);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ObjectGID = reader.ReadVarShort();
	}
}
}
