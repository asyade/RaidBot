using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayDelayedActionMessage : NetworkMessage
{

	public const uint Id = 6153;
	public override uint MessageId { get { return Id; } }

	public double DelayedCharacterId { get; set; }
	public byte DelayTypeId { get; set; }
	public double DelayEndTime { get; set; }

	public GameRolePlayDelayedActionMessage() {}


	public GameRolePlayDelayedActionMessage InitGameRolePlayDelayedActionMessage(double DelayedCharacterId, byte DelayTypeId, double DelayEndTime)
	{
		this.DelayedCharacterId = DelayedCharacterId;
		this.DelayTypeId = DelayTypeId;
		this.DelayEndTime = DelayEndTime;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.DelayedCharacterId);
		writer.WriteByte(this.DelayTypeId);
		writer.WriteDouble(this.DelayEndTime);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DelayedCharacterId = reader.ReadDouble();
		this.DelayTypeId = reader.ReadByte();
		this.DelayEndTime = reader.ReadDouble();
	}
}
}
