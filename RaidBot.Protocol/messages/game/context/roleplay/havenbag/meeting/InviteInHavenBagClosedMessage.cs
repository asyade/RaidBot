using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class InviteInHavenBagClosedMessage : NetworkMessage
{

	public const uint Id = 6645;
	public override uint MessageId { get { return Id; } }

	public CharacterMinimalInformations HostInformations { get; set; }

	public InviteInHavenBagClosedMessage() {}


	public InviteInHavenBagClosedMessage InitInviteInHavenBagClosedMessage(CharacterMinimalInformations HostInformations)
	{
		this.HostInformations = HostInformations;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.HostInformations.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HostInformations = new CharacterMinimalInformations();
		this.HostInformations.Deserialize(reader);
	}
}
}
