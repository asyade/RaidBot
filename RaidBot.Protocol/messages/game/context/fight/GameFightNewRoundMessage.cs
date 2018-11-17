using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightNewRoundMessage : NetworkMessage
{

	public const uint Id = 6239;
	public override uint MessageId { get { return Id; } }

	public int RoundNumber { get; set; }

	public GameFightNewRoundMessage() {}


	public GameFightNewRoundMessage InitGameFightNewRoundMessage(int RoundNumber)
	{
		this.RoundNumber = RoundNumber;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.RoundNumber);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.RoundNumber = reader.ReadVarInt();
	}
}
}
