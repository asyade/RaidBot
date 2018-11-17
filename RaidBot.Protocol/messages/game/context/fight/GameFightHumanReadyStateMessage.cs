using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightHumanReadyStateMessage : NetworkMessage
{

	public const uint Id = 740;
	public override uint MessageId { get { return Id; } }

	public long CharacterId { get; set; }
	public bool IsReady { get; set; }

	public GameFightHumanReadyStateMessage() {}


	public GameFightHumanReadyStateMessage InitGameFightHumanReadyStateMessage(long CharacterId, bool IsReady)
	{
		this.CharacterId = CharacterId;
		this.IsReady = IsReady;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.CharacterId);
		writer.WriteBoolean(this.IsReady);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CharacterId = reader.ReadVarLong();
		this.IsReady = reader.ReadBoolean();
	}
}
}
