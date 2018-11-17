using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightTriggeredEffect : AbstractFightDispellableEffect
{

	public const uint Id = 210;
	public override uint MessageId { get { return Id; } }

	public short Delay { get; set; }

	public FightTriggeredEffect() {}


	public FightTriggeredEffect InitFightTriggeredEffect(short Delay)
	{
		this.Delay = Delay;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.Delay);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Delay = reader.ReadShort();
	}
}
}
