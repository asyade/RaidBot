using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DungeonKeyRingUpdateMessage : NetworkMessage
{

	public const uint Id = 6296;
	public override uint MessageId { get { return Id; } }

	public short DungeonId { get; set; }
	public bool Available { get; set; }

	public DungeonKeyRingUpdateMessage() {}


	public DungeonKeyRingUpdateMessage InitDungeonKeyRingUpdateMessage(short DungeonId, bool Available)
	{
		this.DungeonId = DungeonId;
		this.Available = Available;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.DungeonId);
		writer.WriteBoolean(this.Available);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DungeonId = reader.ReadVarShort();
		this.Available = reader.ReadBoolean();
	}
}
}
