using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class NotificationUpdateFlagMessage : NetworkMessage
{

	public const uint Id = 6090;
	public override uint MessageId { get { return Id; } }

	public short Index { get; set; }

	public NotificationUpdateFlagMessage() {}


	public NotificationUpdateFlagMessage InitNotificationUpdateFlagMessage(short Index)
	{
		this.Index = Index;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.Index);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Index = reader.ReadVarShort();
	}
}
}
