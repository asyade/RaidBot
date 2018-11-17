using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class BasicAckMessage : NetworkMessage
{

	public const uint Id = 6362;
	public override uint MessageId { get { return Id; } }

	public int Seq { get; set; }
	public short LastPacketId { get; set; }

	public BasicAckMessage() {}


	public BasicAckMessage InitBasicAckMessage(int Seq, short LastPacketId)
	{
		this.Seq = Seq;
		this.LastPacketId = LastPacketId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.Seq);
		writer.WriteVarShort(this.LastPacketId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Seq = reader.ReadVarInt();
		this.LastPacketId = reader.ReadVarShort();
	}
}
}
