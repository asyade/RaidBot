using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class InteractiveUseWithParamRequestMessage : InteractiveUseRequestMessage
{

	public const uint Id = 6715;
	public override uint MessageId { get { return Id; } }

	public int Id_ { get; set; }

	public InteractiveUseWithParamRequestMessage() {}


	public InteractiveUseWithParamRequestMessage InitInteractiveUseWithParamRequestMessage(int Id_)
	{
		this.Id_ = Id_;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteInt(this.Id_);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Id_ = reader.ReadInt();
	}
}
}
