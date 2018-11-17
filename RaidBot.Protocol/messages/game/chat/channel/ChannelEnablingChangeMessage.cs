using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ChannelEnablingChangeMessage : NetworkMessage
{

	public const uint Id = 891;
	public override uint MessageId { get { return Id; } }

	public byte Channel { get; set; }
	public bool Enable { get; set; }

	public ChannelEnablingChangeMessage() {}


	public ChannelEnablingChangeMessage InitChannelEnablingChangeMessage(byte Channel, bool Enable)
	{
		this.Channel = Channel;
		this.Enable = Enable;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Channel);
		writer.WriteBoolean(this.Enable);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Channel = reader.ReadByte();
		this.Enable = reader.ReadBoolean();
	}
}
}
