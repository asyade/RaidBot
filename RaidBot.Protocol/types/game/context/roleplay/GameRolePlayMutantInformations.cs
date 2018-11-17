using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayMutantInformations : GameRolePlayHumanoidInformations
{

	public const uint Id = 3;
	public override uint MessageId { get { return Id; } }

	public short MonsterId { get; set; }
	public byte PowerLevel { get; set; }

	public GameRolePlayMutantInformations() {}


	public GameRolePlayMutantInformations InitGameRolePlayMutantInformations(short MonsterId, byte PowerLevel)
	{
		this.MonsterId = MonsterId;
		this.PowerLevel = PowerLevel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.MonsterId);
		writer.WriteByte(this.PowerLevel);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.MonsterId = reader.ReadVarShort();
		this.PowerLevel = reader.ReadByte();
	}
}
}
