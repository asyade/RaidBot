using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SpellVariantActivationMessage : NetworkMessage
{

	public const uint Id = 6705;
	public override uint MessageId { get { return Id; } }

	public short SpellId { get; set; }
	public bool Result { get; set; }

	public SpellVariantActivationMessage() {}


	public SpellVariantActivationMessage InitSpellVariantActivationMessage(short SpellId, bool Result)
	{
		this.SpellId = SpellId;
		this.Result = Result;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SpellId);
		writer.WriteBoolean(this.Result);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SpellId = reader.ReadVarShort();
		this.Result = reader.ReadBoolean();
	}
}
}
