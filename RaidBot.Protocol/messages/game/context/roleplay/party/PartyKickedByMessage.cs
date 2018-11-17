using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyKickedByMessage : AbstractPartyMessage
{

	public const uint Id = 5590;
	public override uint MessageId { get { return Id; } }

	public long KickerId { get; set; }

	public PartyKickedByMessage() {}


	public PartyKickedByMessage InitPartyKickedByMessage(long KickerId)
	{
		this.KickerId = KickerId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.KickerId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.KickerId = reader.ReadVarLong();
	}
}
}
