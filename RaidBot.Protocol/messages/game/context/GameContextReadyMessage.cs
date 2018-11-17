using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameContextReadyMessage : NetworkMessage
{

	public const uint Id = 6071;
	public override uint MessageId { get { return Id; } }

	public double MapId { get; set; }

	public GameContextReadyMessage() {}


	public GameContextReadyMessage InitGameContextReadyMessage(double MapId)
	{
		this.MapId = MapId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.MapId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MapId = reader.ReadDouble();
	}
}
}
