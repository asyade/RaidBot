using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightLoot : NetworkType
{

	public const uint Id = 41;
	public override uint MessageId { get { return Id; } }

	public short[] Objects { get; set; }
	public long Kamas { get; set; }

	public FightLoot() {}


	public FightLoot InitFightLoot(short[] Objects, long Kamas)
	{
		this.Objects = Objects;
		this.Kamas = Kamas;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Objects.Length);
		foreach (short item in this.Objects)
		{
			writer.WriteVarShort(item);
		}
		writer.WriteVarLong(this.Kamas);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int ObjectsLen = reader.ReadShort();
		Objects = new short[ObjectsLen];
		for (int i = 0; i < ObjectsLen; i++)
		{
			this.Objects[i] = reader.ReadVarShort();
		}
		this.Kamas = reader.ReadVarLong();
	}
}
}
