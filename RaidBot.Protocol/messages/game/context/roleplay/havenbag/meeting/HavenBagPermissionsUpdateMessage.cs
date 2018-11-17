using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HavenBagPermissionsUpdateMessage : NetworkMessage
{

	public const uint Id = 6713;
	public override uint MessageId { get { return Id; } }

	public int Permissions { get; set; }

	public HavenBagPermissionsUpdateMessage() {}


	public HavenBagPermissionsUpdateMessage InitHavenBagPermissionsUpdateMessage(int Permissions)
	{
		this.Permissions = Permissions;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.Permissions);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Permissions = reader.ReadInt();
	}
}
}
