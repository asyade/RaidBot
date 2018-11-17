using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class InviteInHavenBagMessage : NetworkMessage
{

	public const uint Id = 6642;
	public override uint MessageId { get { return Id; } }

	public CharacterMinimalInformations GuestInformations { get; set; }
	public bool Accept { get; set; }

	public InviteInHavenBagMessage() {}


	public InviteInHavenBagMessage InitInviteInHavenBagMessage(CharacterMinimalInformations GuestInformations, bool Accept)
	{
		this.GuestInformations = GuestInformations;
		this.Accept = Accept;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.GuestInformations.Serialize(writer);
		writer.WriteBoolean(this.Accept);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.GuestInformations = new CharacterMinimalInformations();
		this.GuestInformations.Deserialize(reader);
		this.Accept = reader.ReadBoolean();
	}
}
}
