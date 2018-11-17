using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class InteractiveElementUpdatedMessage : NetworkMessage
{

	public const uint Id = 5708;
	public override uint MessageId { get { return Id; } }

	public InteractiveElement InteractiveElement { get; set; }

	public InteractiveElementUpdatedMessage() {}


	public InteractiveElementUpdatedMessage InitInteractiveElementUpdatedMessage(InteractiveElement InteractiveElement)
	{
		this.InteractiveElement = InteractiveElement;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.InteractiveElement.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.InteractiveElement = new InteractiveElement();
		this.InteractiveElement.Deserialize(reader);
	}
}
}
