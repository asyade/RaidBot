using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeStartedWithStorageMessage : ExchangeStartedMessage
{

	public const uint Id = 6236;
	public override uint MessageId { get { return Id; } }

	public int StorageMaxSlot { get; set; }

	public ExchangeStartedWithStorageMessage() {}


	public ExchangeStartedWithStorageMessage InitExchangeStartedWithStorageMessage(int StorageMaxSlot)
	{
		this.StorageMaxSlot = StorageMaxSlot;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.StorageMaxSlot);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.StorageMaxSlot = reader.ReadVarInt();
	}
}
}
