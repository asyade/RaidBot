using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class IdolPartyLostMessage : NetworkMessage
{

	public const uint Id = 6580;
	public override uint MessageId { get { return Id; } }

	public short IdolId { get; set; }

	public IdolPartyLostMessage() {}


	public IdolPartyLostMessage InitIdolPartyLostMessage(short IdolId)
	{
		this.IdolId = IdolId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.IdolId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.IdolId = reader.ReadVarShort();
	}
}
}
