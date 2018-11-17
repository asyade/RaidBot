using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyInvitationRequestMessage : NetworkMessage
{

	public const uint Id = 5585;
	public override uint MessageId { get { return Id; } }

	public String Name { get; set; }

	public PartyInvitationRequestMessage() {}


	public PartyInvitationRequestMessage InitPartyInvitationRequestMessage(String Name)
	{
		this.Name = Name;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Name);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Name = reader.ReadUTF();
	}
}
}
