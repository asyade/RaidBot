using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MountEmoteIconUsedOkMessage : NetworkMessage
{

	public const uint Id = 5978;
	public override uint MessageId { get { return Id; } }

	public int MountId { get; set; }
	public byte ReactionType { get; set; }

	public MountEmoteIconUsedOkMessage() {}


	public MountEmoteIconUsedOkMessage InitMountEmoteIconUsedOkMessage(int MountId, byte ReactionType)
	{
		this.MountId = MountId;
		this.ReactionType = ReactionType;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.MountId);
		writer.WriteByte(this.ReactionType);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MountId = reader.ReadVarInt();
		this.ReactionType = reader.ReadByte();
	}
}
}
