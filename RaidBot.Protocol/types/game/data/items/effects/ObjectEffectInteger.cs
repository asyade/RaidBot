using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectEffectInteger : ObjectEffect
{

	public const uint Id = 70;
	public override uint MessageId { get { return Id; } }

	public int Value { get; set; }

	public ObjectEffectInteger() {}


	public ObjectEffectInteger InitObjectEffectInteger(int Value)
	{
		this.Value = Value;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.Value);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Value = reader.ReadVarInt();
	}
}
}
