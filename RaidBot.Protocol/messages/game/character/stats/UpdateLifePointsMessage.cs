using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class UpdateLifePointsMessage : NetworkMessage
{

	public const uint Id = 5658;
	public override uint MessageId { get { return Id; } }

	public int LifePoints { get; set; }
	public int MaxLifePoints { get; set; }

	public UpdateLifePointsMessage() {}


	public UpdateLifePointsMessage InitUpdateLifePointsMessage(int LifePoints, int MaxLifePoints)
	{
		this.LifePoints = LifePoints;
		this.MaxLifePoints = MaxLifePoints;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.LifePoints);
		writer.WriteVarInt(this.MaxLifePoints);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.LifePoints = reader.ReadVarInt();
		this.MaxLifePoints = reader.ReadVarInt();
	}
}
}
