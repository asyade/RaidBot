using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightTemporaryBoostEffect : AbstractFightDispellableEffect
{

	public const uint Id = 209;
	public override uint MessageId { get { return Id; } }

	public short Delta { get; set; }

	public FightTemporaryBoostEffect() {}


	public FightTemporaryBoostEffect InitFightTemporaryBoostEffect(short Delta)
	{
		this.Delta = Delta;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.Delta);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Delta = reader.ReadShort();
	}
}
}
