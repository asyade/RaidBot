using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameContextKickMessage : NetworkMessage
{

	public const uint Id = 6081;
	public override uint MessageId { get { return Id; } }

	public double TargetId { get; set; }

	public GameContextKickMessage() {}


	public GameContextKickMessage InitGameContextKickMessage(double TargetId)
	{
		this.TargetId = TargetId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.TargetId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.TargetId = reader.ReadDouble();
	}
}
}
