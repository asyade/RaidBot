using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SpellVariantActivationRequestMessage : NetworkMessage
{

	public const uint Id = 6707;
	public override uint MessageId { get { return Id; } }

	public short SpellId { get; set; }

	public SpellVariantActivationRequestMessage() {}


	public SpellVariantActivationRequestMessage InitSpellVariantActivationRequestMessage(short SpellId)
	{
		this.SpellId = SpellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SpellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SpellId = reader.ReadVarShort();
	}
}
}
