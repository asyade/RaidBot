using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightFighterTaxCollectorLightInformations : GameFightFighterLightInformations
{

	public const uint Id = 457;
	public override uint MessageId { get { return Id; } }

	public short FirstNameId { get; set; }
	public short LastNameId { get; set; }

	public GameFightFighterTaxCollectorLightInformations() {}


	public GameFightFighterTaxCollectorLightInformations InitGameFightFighterTaxCollectorLightInformations(short FirstNameId, short LastNameId)
	{
		this.FirstNameId = FirstNameId;
		this.LastNameId = LastNameId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.FirstNameId);
		writer.WriteVarShort(this.LastNameId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.FirstNameId = reader.ReadVarShort();
		this.LastNameId = reader.ReadVarShort();
	}
}
}
