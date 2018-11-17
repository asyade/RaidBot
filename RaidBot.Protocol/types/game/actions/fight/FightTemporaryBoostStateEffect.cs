using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightTemporaryBoostStateEffect : FightTemporaryBoostEffect
{

	public const uint Id = 214;
	public override uint MessageId { get { return Id; } }

	public short StateId { get; set; }

	public FightTemporaryBoostStateEffect() {}


	public FightTemporaryBoostStateEffect InitFightTemporaryBoostStateEffect(short StateId)
	{
		this.StateId = StateId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.StateId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.StateId = reader.ReadShort();
	}
}
}
