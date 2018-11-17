using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayArenaRegistrationStatusMessage : NetworkMessage
{

	public const uint Id = 6284;
	public override uint MessageId { get { return Id; } }

	public bool Registered { get; set; }
	public byte Step { get; set; }
	public int BattleMode { get; set; }

	public GameRolePlayArenaRegistrationStatusMessage() {}


	public GameRolePlayArenaRegistrationStatusMessage InitGameRolePlayArenaRegistrationStatusMessage(bool Registered, byte Step, int BattleMode)
	{
		this.Registered = Registered;
		this.Step = Step;
		this.BattleMode = BattleMode;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Registered);
		writer.WriteByte(this.Step);
		writer.WriteInt(this.BattleMode);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Registered = reader.ReadBoolean();
		this.Step = reader.ReadByte();
		this.BattleMode = reader.ReadInt();
	}
}
}
