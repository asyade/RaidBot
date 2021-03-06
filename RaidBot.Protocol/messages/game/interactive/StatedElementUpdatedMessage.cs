using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class StatedElementUpdatedMessage : NetworkMessage
{

	public const uint Id = 5709;
	public override uint MessageId { get { return Id; } }

	public StatedElement StatedElement { get; set; }

	public StatedElementUpdatedMessage() {}


	public StatedElementUpdatedMessage InitStatedElementUpdatedMessage(StatedElement StatedElement)
	{
		this.StatedElement = StatedElement;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.StatedElement.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.StatedElement = new StatedElement();
		this.StatedElement.Deserialize(reader);
	}
}
}
