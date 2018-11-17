using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ShortcutBarSwapRequestMessage : NetworkMessage
{

	public const uint Id = 6230;
	public override uint MessageId { get { return Id; } }

	public byte BarType { get; set; }
	public byte FirstSlot { get; set; }
	public byte SecondSlot { get; set; }

	public ShortcutBarSwapRequestMessage() {}


	public ShortcutBarSwapRequestMessage InitShortcutBarSwapRequestMessage(byte BarType, byte FirstSlot, byte SecondSlot)
	{
		this.BarType = BarType;
		this.FirstSlot = FirstSlot;
		this.SecondSlot = SecondSlot;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.BarType);
		writer.WriteByte(this.FirstSlot);
		writer.WriteByte(this.SecondSlot);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.BarType = reader.ReadByte();
		this.FirstSlot = reader.ReadByte();
		this.SecondSlot = reader.ReadByte();
	}
}
}
