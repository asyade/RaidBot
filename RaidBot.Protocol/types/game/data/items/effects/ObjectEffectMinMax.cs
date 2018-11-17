using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectEffectMinMax : ObjectEffect
{

	public const uint Id = 82;
	public override uint MessageId { get { return Id; } }

	public int Min { get; set; }
	public int Max { get; set; }

	public ObjectEffectMinMax() {}


	public ObjectEffectMinMax InitObjectEffectMinMax(int Min, int Max)
	{
		this.Min = Min;
		this.Max = Max;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.Min);
		writer.WriteVarInt(this.Max);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Min = reader.ReadVarInt();
		this.Max = reader.ReadVarInt();
	}
}
}
