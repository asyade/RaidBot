using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayRemoveChallengeMessage : NetworkMessage
{

	public const uint Id = 300;
	public override uint MessageId { get { return Id; } }

	public short FightId { get; set; }

	public GameRolePlayRemoveChallengeMessage() {}


	public GameRolePlayRemoveChallengeMessage InitGameRolePlayRemoveChallengeMessage(short FightId)
	{
		this.FightId = FightId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.FightId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FightId = reader.ReadVarShort();
	}
}
}
