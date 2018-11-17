using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightTurnFinishMessage : NetworkMessage
{

	public const uint Id = 718;
	public override uint MessageId { get { return Id; } }

	public bool IsAfk { get; set; }

	public GameFightTurnFinishMessage() {}


	public GameFightTurnFinishMessage InitGameFightTurnFinishMessage(bool IsAfk)
	{
		this.IsAfk = IsAfk;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.IsAfk);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.IsAfk = reader.ReadBoolean();
	}
}
}
