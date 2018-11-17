using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LivingObjectDissociateMessage : NetworkMessage
{

	public const uint Id = 5723;
	public override uint MessageId { get { return Id; } }

	public int LivingUID { get; set; }
	public byte LivingPosition { get; set; }

	public LivingObjectDissociateMessage() {}


	public LivingObjectDissociateMessage InitLivingObjectDissociateMessage(int LivingUID, byte LivingPosition)
	{
		this.LivingUID = LivingUID;
		this.LivingPosition = LivingPosition;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.LivingUID);
		writer.WriteByte(this.LivingPosition);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.LivingUID = reader.ReadVarInt();
		this.LivingPosition = reader.ReadByte();
	}
}
}
