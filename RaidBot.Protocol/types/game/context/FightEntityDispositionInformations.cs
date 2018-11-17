using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightEntityDispositionInformations : EntityDispositionInformations
{

	public const uint Id = 217;
	public override uint MessageId { get { return Id; } }

	public double CarryingCharacterId { get; set; }

	public FightEntityDispositionInformations() {}


	public FightEntityDispositionInformations InitFightEntityDispositionInformations(double CarryingCharacterId)
	{
		this.CarryingCharacterId = CarryingCharacterId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.CarryingCharacterId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.CarryingCharacterId = reader.ReadDouble();
	}
}
}
