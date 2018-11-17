using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightFighterMonsterLightInformations : GameFightFighterLightInformations
{

	public const uint Id = 455;
	public override uint MessageId { get { return Id; } }

	public short CreatureGenericId { get; set; }

	public GameFightFighterMonsterLightInformations() {}


	public GameFightFighterMonsterLightInformations InitGameFightFighterMonsterLightInformations(short CreatureGenericId)
	{
		this.CreatureGenericId = CreatureGenericId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.CreatureGenericId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.CreatureGenericId = reader.ReadVarShort();
	}
}
}
