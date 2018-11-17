using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightPlacementSwapPositionsRequestMessage : GameFightPlacementPositionRequestMessage
{

	public const uint Id = 6541;
	public override uint MessageId { get { return Id; } }

	public double RequestedId { get; set; }

	public GameFightPlacementSwapPositionsRequestMessage() {}


	public GameFightPlacementSwapPositionsRequestMessage InitGameFightPlacementSwapPositionsRequestMessage(double RequestedId)
	{
		this.RequestedId = RequestedId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.RequestedId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.RequestedId = reader.ReadDouble();
	}
}
}
