using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightTurnReadyMessage : NetworkMessage
{

	public const uint Id = 716;
	public override uint MessageId { get { return Id; } }

	public bool IsReady { get; set; }

	public GameFightTurnReadyMessage() {}


	public GameFightTurnReadyMessage InitGameFightTurnReadyMessage(bool IsReady)
	{
		this.IsReady = IsReady;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.IsReady);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.IsReady = reader.ReadBoolean();
	}
}
}
