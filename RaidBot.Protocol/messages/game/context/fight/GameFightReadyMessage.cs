using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightReadyMessage : NetworkMessage
{

	public const uint Id = 708;
	public override uint MessageId { get { return Id; } }

	public bool IsReady { get; set; }

	public GameFightReadyMessage() {}


	public GameFightReadyMessage InitGameFightReadyMessage(bool IsReady)
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
