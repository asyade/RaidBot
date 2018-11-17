using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectEffectCreature : ObjectEffect
{

	public const uint Id = 71;
	public override uint MessageId { get { return Id; } }

	public short MonsterFamilyId { get; set; }

	public ObjectEffectCreature() {}


	public ObjectEffectCreature InitObjectEffectCreature(short MonsterFamilyId)
	{
		this.MonsterFamilyId = MonsterFamilyId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.MonsterFamilyId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.MonsterFamilyId = reader.ReadVarShort();
	}
}
}
