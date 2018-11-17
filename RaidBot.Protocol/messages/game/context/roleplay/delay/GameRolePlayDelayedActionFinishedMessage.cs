using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayDelayedActionFinishedMessage : NetworkMessage
{

	public const uint Id = 6150;
	public override uint MessageId { get { return Id; } }

	public double DelayedCharacterId { get; set; }
	public byte DelayTypeId { get; set; }

	public GameRolePlayDelayedActionFinishedMessage() {}


	public GameRolePlayDelayedActionFinishedMessage InitGameRolePlayDelayedActionFinishedMessage(double DelayedCharacterId, byte DelayTypeId)
	{
		this.DelayedCharacterId = DelayedCharacterId;
		this.DelayTypeId = DelayTypeId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.DelayedCharacterId);
		writer.WriteByte(this.DelayTypeId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DelayedCharacterId = reader.ReadDouble();
		this.DelayTypeId = reader.ReadByte();
	}
}
}
