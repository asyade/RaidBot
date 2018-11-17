using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightPlacementSwapPositionsCancelledMessage : NetworkMessage
{

	public const uint Id = 6546;
	public override uint MessageId { get { return Id; } }

	public int RequestId { get; set; }
	public double CancellerId { get; set; }

	public GameFightPlacementSwapPositionsCancelledMessage() {}


	public GameFightPlacementSwapPositionsCancelledMessage InitGameFightPlacementSwapPositionsCancelledMessage(int RequestId, double CancellerId)
	{
		this.RequestId = RequestId;
		this.CancellerId = CancellerId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.RequestId);
		writer.WriteDouble(this.CancellerId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.RequestId = reader.ReadInt();
		this.CancellerId = reader.ReadDouble();
	}
}
}
