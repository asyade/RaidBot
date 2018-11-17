using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeObjectTransfertListToInvMessage : NetworkMessage
{

	public const uint Id = 6039;
	public override uint MessageId { get { return Id; } }

	public int[] Ids { get; set; }

	public ExchangeObjectTransfertListToInvMessage() {}


	public ExchangeObjectTransfertListToInvMessage InitExchangeObjectTransfertListToInvMessage(int[] Ids)
	{
		this.Ids = Ids;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Ids.Length);
		foreach (int item in this.Ids)
		{
			writer.WriteVarInt(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int IdsLen = reader.ReadShort();
		Ids = new int[IdsLen];
		for (int i = 0; i < IdsLen; i++)
		{
			this.Ids[i] = reader.ReadVarInt();
		}
	}
}
}
