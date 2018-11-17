using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayPlayerFightFriendlyAnswerMessage : NetworkMessage
{

	public const uint Id = 5732;
	public override uint MessageId { get { return Id; } }

	public short FightId { get; set; }
	public bool Accept { get; set; }

	public GameRolePlayPlayerFightFriendlyAnswerMessage() {}


	public GameRolePlayPlayerFightFriendlyAnswerMessage InitGameRolePlayPlayerFightFriendlyAnswerMessage(short FightId, bool Accept)
	{
		this.FightId = FightId;
		this.Accept = Accept;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.FightId);
		writer.WriteBoolean(this.Accept);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FightId = reader.ReadVarShort();
		this.Accept = reader.ReadBoolean();
	}
}
}
