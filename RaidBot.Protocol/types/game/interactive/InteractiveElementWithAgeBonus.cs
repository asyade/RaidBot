using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class InteractiveElementWithAgeBonus : InteractiveElement
{

	public const uint Id = 398;
	public override uint MessageId { get { return Id; } }

	public short AgeBonus { get; set; }

	public InteractiveElementWithAgeBonus() {}


	public InteractiveElementWithAgeBonus InitInteractiveElementWithAgeBonus(short AgeBonus)
	{
		this.AgeBonus = AgeBonus;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.AgeBonus);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.AgeBonus = reader.ReadShort();
	}
}
}
