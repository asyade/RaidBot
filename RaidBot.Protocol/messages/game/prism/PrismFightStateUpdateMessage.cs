using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismFightStateUpdateMessage : NetworkMessage
{

	public const uint Id = 6040;
	public override uint MessageId { get { return Id; } }

	public byte State { get; set; }

	public PrismFightStateUpdateMessage() {}


	public PrismFightStateUpdateMessage InitPrismFightStateUpdateMessage(byte State)
	{
		this.State = State;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.State);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.State = reader.ReadByte();
	}
}
}
