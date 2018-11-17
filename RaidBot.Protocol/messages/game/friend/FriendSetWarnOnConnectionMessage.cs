using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FriendSetWarnOnConnectionMessage : NetworkMessage
{

	public const uint Id = 5602;
	public override uint MessageId { get { return Id; } }

	public bool Enable { get; set; }

	public FriendSetWarnOnConnectionMessage() {}


	public FriendSetWarnOnConnectionMessage InitFriendSetWarnOnConnectionMessage(bool Enable)
	{
		this.Enable = Enable;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Enable);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Enable = reader.ReadBoolean();
	}
}
}
