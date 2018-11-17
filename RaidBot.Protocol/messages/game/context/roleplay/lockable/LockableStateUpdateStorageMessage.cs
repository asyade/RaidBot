using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LockableStateUpdateStorageMessage : LockableStateUpdateAbstractMessage
{

	public const uint Id = 5669;
	public override uint MessageId { get { return Id; } }

	public double MapId { get; set; }
	public int ElementId { get; set; }

	public LockableStateUpdateStorageMessage() {}


	public LockableStateUpdateStorageMessage InitLockableStateUpdateStorageMessage(double MapId, int ElementId)
	{
		this.MapId = MapId;
		this.ElementId = ElementId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.MapId);
		writer.WriteVarInt(this.ElementId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.MapId = reader.ReadDouble();
		this.ElementId = reader.ReadVarInt();
	}
}
}
