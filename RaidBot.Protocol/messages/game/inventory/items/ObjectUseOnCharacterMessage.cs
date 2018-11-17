using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectUseOnCharacterMessage : ObjectUseMessage
{

	public const uint Id = 3003;
	public override uint MessageId { get { return Id; } }

	public long CharacterId { get; set; }

	public ObjectUseOnCharacterMessage() {}


	public ObjectUseOnCharacterMessage InitObjectUseOnCharacterMessage(long CharacterId)
	{
		this.CharacterId = CharacterId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.CharacterId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.CharacterId = reader.ReadVarLong();
	}
}
}
