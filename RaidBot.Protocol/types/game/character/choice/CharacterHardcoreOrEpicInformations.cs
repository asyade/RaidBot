using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterHardcoreOrEpicInformations : CharacterBaseInformations
{

	public const uint Id = 474;
	public override uint MessageId { get { return Id; } }

	public byte DeathState { get; set; }
	public short DeathCount { get; set; }
	public short DeathMaxLevel { get; set; }

	public CharacterHardcoreOrEpicInformations() {}


	public CharacterHardcoreOrEpicInformations InitCharacterHardcoreOrEpicInformations(byte DeathState, short DeathCount, short DeathMaxLevel)
	{
		this.DeathState = DeathState;
		this.DeathCount = DeathCount;
		this.DeathMaxLevel = DeathMaxLevel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.DeathState);
		writer.WriteVarShort(this.DeathCount);
		writer.WriteVarShort(this.DeathMaxLevel);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.DeathState = reader.ReadByte();
		this.DeathCount = reader.ReadVarShort();
		this.DeathMaxLevel = reader.ReadVarShort();
	}
}
}
