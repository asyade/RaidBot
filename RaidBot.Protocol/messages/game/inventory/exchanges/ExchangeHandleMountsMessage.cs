using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeHandleMountsMessage : NetworkMessage
{

	public const uint Id = 6752;
	public override uint MessageId { get { return Id; } }

	public byte ActionType { get; set; }
	public int[] RidesId { get; set; }

	public ExchangeHandleMountsMessage() {}


	public ExchangeHandleMountsMessage InitExchangeHandleMountsMessage(byte ActionType, int[] RidesId)
	{
		this.ActionType = ActionType;
		this.RidesId = RidesId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.ActionType);
		writer.WriteShort(this.RidesId.Length);
		foreach (int item in this.RidesId)
		{
			writer.WriteVarInt(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ActionType = reader.ReadByte();
		int RidesIdLen = reader.ReadShort();
		RidesId = new int[RidesIdLen];
		for (int i = 0; i < RidesIdLen; i++)
		{
			this.RidesId[i] = reader.ReadVarInt();
		}
	}
}
}
