using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightPauseMessage : NetworkMessage
{

	public const uint Id = 6754;
	public override uint MessageId { get { return Id; } }

	public bool IsPaused { get; set; }

	public GameFightPauseMessage() {}


	public GameFightPauseMessage InitGameFightPauseMessage(bool IsPaused)
	{
		this.IsPaused = IsPaused;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.IsPaused);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.IsPaused = reader.ReadBoolean();
	}
}
}
