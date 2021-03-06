using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AccessoryPreviewMessage : NetworkMessage
{

	public const uint Id = 6517;
	public override uint MessageId { get { return Id; } }

	public EntityLook Look { get; set; }

	public AccessoryPreviewMessage() {}


	public AccessoryPreviewMessage InitAccessoryPreviewMessage(EntityLook Look)
	{
		this.Look = Look;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Look.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Look = new EntityLook();
		this.Look.Deserialize(reader);
	}
}
}
