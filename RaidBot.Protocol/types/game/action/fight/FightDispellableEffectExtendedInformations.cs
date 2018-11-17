using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightDispellableEffectExtendedInformations : NetworkType
{

	public const uint Id = 208;
	public override uint MessageId { get { return Id; } }

	public short ActionId { get; set; }
	public double SourceId { get; set; }

	public FightDispellableEffectExtendedInformations() {}


	public FightDispellableEffectExtendedInformations InitFightDispellableEffectExtendedInformations(short ActionId, double SourceId)
	{
		this.ActionId = ActionId;
		this.SourceId = SourceId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ActionId);
		writer.WriteDouble(this.SourceId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ActionId = reader.ReadVarShort();
		this.SourceId = reader.ReadDouble();
	}
}
}
