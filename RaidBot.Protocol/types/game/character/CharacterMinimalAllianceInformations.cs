using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterMinimalAllianceInformations : CharacterMinimalGuildInformations
{

	public const uint Id = 444;
	public override uint MessageId { get { return Id; } }

	public BasicAllianceInformations Alliance { get; set; }

	public CharacterMinimalAllianceInformations() {}


	public CharacterMinimalAllianceInformations InitCharacterMinimalAllianceInformations(BasicAllianceInformations Alliance)
	{
		this.Alliance = Alliance;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.Alliance.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Alliance = new BasicAllianceInformations();
		this.Alliance.Deserialize(reader);
	}
}
}
