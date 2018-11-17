using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class NpcGenericActionRequestMessage : NetworkMessage
{

	public const uint Id = 5898;
	public override uint MessageId { get { return Id; } }

	public int NpcId { get; set; }
	public byte NpcActionId { get; set; }
	public double NpcMapId { get; set; }

	public NpcGenericActionRequestMessage() {}


	public NpcGenericActionRequestMessage InitNpcGenericActionRequestMessage(int NpcId, byte NpcActionId, double NpcMapId)
	{
		this.NpcId = NpcId;
		this.NpcActionId = NpcActionId;
		this.NpcMapId = NpcMapId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.NpcId);
		writer.WriteByte(this.NpcActionId);
		writer.WriteDouble(this.NpcMapId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.NpcId = reader.ReadInt();
		this.NpcActionId = reader.ReadByte();
		this.NpcMapId = reader.ReadDouble();
	}
}
}
