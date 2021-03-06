using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyCannotJoinErrorMessage : AbstractPartyMessage
{

	public const uint Id = 5583;
	public override uint MessageId { get { return Id; } }

	public byte Reason { get; set; }

	public PartyCannotJoinErrorMessage() {}


	public PartyCannotJoinErrorMessage InitPartyCannotJoinErrorMessage(byte Reason)
	{
		this.Reason = Reason;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.Reason);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Reason = reader.ReadByte();
	}
}
}
