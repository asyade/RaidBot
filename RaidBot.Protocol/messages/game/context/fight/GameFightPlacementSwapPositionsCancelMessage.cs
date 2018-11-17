using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightPlacementSwapPositionsCancelMessage : NetworkMessage
{

	public const uint Id = 6543;
	public override uint MessageId { get { return Id; } }

	public int RequestId { get; set; }

	public GameFightPlacementSwapPositionsCancelMessage() {}


	public GameFightPlacementSwapPositionsCancelMessage InitGameFightPlacementSwapPositionsCancelMessage(int RequestId)
	{
		this.RequestId = RequestId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.RequestId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.RequestId = reader.ReadInt();
	}
}
}
