using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FocusedExchangeReadyMessage : ExchangeReadyMessage
{

	public const uint Id = 6701;
	public override uint MessageId { get { return Id; } }

	public int FocusActionId { get; set; }

	public FocusedExchangeReadyMessage() {}


	public FocusedExchangeReadyMessage InitFocusedExchangeReadyMessage(int FocusActionId)
	{
		this.FocusActionId = FocusActionId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.FocusActionId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.FocusActionId = reader.ReadVarInt();
	}
}
}
