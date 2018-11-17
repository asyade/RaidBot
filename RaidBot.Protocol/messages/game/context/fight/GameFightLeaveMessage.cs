using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightLeaveMessage : NetworkMessage
{

	public const uint Id = 721;
	public override uint MessageId { get { return Id; } }

	public double CharId { get; set; }

	public GameFightLeaveMessage() {}


	public GameFightLeaveMessage InitGameFightLeaveMessage(double CharId)
	{
		this.CharId = CharId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.CharId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CharId = reader.ReadDouble();
	}
}
}
