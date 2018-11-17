using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameMapMovementRequestMessage : NetworkMessage
{

	public const uint Id = 950;
	public override uint MessageId { get { return Id; } }

	public short[] KeyMovements { get; set; }
	public double MapId { get; set; }

	public GameMapMovementRequestMessage() {}


	public GameMapMovementRequestMessage InitGameMapMovementRequestMessage(short[] KeyMovements, double MapId)
	{
		this.KeyMovements = KeyMovements;
		this.MapId = MapId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.KeyMovements.Length);
		foreach (short item in this.KeyMovements)
		{
			writer.WriteShort(item);
		}
		writer.WriteDouble(this.MapId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int KeyMovementsLen = reader.ReadShort();
		KeyMovements = new short[KeyMovementsLen];
		for (int i = 0; i < KeyMovementsLen; i++)
		{
			this.KeyMovements[i] = reader.ReadShort();
		}
		this.MapId = reader.ReadDouble();
	}
}
}
