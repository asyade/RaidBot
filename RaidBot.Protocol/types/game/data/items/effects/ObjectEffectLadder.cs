using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectEffectLadder : ObjectEffectCreature
{

	public const uint Id = 81;
	public override uint MessageId { get { return Id; } }

	public int MonsterCount { get; set; }

	public ObjectEffectLadder() {}


	public ObjectEffectLadder InitObjectEffectLadder(int MonsterCount)
	{
		this.MonsterCount = MonsterCount;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.MonsterCount);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.MonsterCount = reader.ReadVarInt();
	}
}
}
