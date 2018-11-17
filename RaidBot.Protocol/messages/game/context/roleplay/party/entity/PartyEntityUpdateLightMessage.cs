using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyEntityUpdateLightMessage : PartyUpdateLightMessage
{

	public const uint Id = 6781;
	public override uint MessageId { get { return Id; } }

	public byte IndexId { get; set; }

	public PartyEntityUpdateLightMessage() {}


	public PartyEntityUpdateLightMessage InitPartyEntityUpdateLightMessage(byte IndexId)
	{
		this.IndexId = IndexId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.IndexId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.IndexId = reader.ReadByte();
	}
}
}
