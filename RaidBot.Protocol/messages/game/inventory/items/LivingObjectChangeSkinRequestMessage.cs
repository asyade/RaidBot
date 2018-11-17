using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LivingObjectChangeSkinRequestMessage : NetworkMessage
{

	public const uint Id = 5725;
	public override uint MessageId { get { return Id; } }

	public int LivingUID { get; set; }
	public byte LivingPosition { get; set; }
	public int SkinId { get; set; }

	public LivingObjectChangeSkinRequestMessage() {}


	public LivingObjectChangeSkinRequestMessage InitLivingObjectChangeSkinRequestMessage(int LivingUID, byte LivingPosition, int SkinId)
	{
		this.LivingUID = LivingUID;
		this.LivingPosition = LivingPosition;
		this.SkinId = SkinId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.LivingUID);
		writer.WriteByte(this.LivingPosition);
		writer.WriteVarInt(this.SkinId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.LivingUID = reader.ReadVarInt();
		this.LivingPosition = reader.ReadByte();
		this.SkinId = reader.ReadVarInt();
	}
}
}
