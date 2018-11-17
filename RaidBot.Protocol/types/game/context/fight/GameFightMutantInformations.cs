using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightMutantInformations : GameFightFighterNamedInformations
{

	public const uint Id = 50;
	public override uint MessageId { get { return Id; } }

	public byte PowerLevel { get; set; }

	public GameFightMutantInformations() {}


	public GameFightMutantInformations InitGameFightMutantInformations(byte PowerLevel)
	{
		this.PowerLevel = PowerLevel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.PowerLevel);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.PowerLevel = reader.ReadByte();
	}
}
}
