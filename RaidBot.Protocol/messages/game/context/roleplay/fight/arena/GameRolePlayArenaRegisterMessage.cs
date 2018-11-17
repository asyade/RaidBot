using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayArenaRegisterMessage : NetworkMessage
{

	public const uint Id = 6280;
	public override uint MessageId { get { return Id; } }

	public int BattleMode { get; set; }

	public GameRolePlayArenaRegisterMessage() {}


	public GameRolePlayArenaRegisterMessage InitGameRolePlayArenaRegisterMessage(int BattleMode)
	{
		this.BattleMode = BattleMode;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.BattleMode);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.BattleMode = reader.ReadInt();
	}
}
}
