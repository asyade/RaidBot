using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AbstractPartyMessage : NetworkMessage
{

	public const uint Id = 6274;
	public override uint MessageId { get { return Id; } }

	public int PartyId { get; set; }

	public AbstractPartyMessage() {}


	public AbstractPartyMessage InitAbstractPartyMessage(int PartyId)
	{
		this.PartyId = PartyId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.PartyId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PartyId = reader.ReadVarInt();
	}
}
}
