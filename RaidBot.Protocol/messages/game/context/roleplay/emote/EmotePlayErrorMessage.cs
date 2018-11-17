using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class EmotePlayErrorMessage : NetworkMessage
{

	public const uint Id = 5688;
	public override uint MessageId { get { return Id; } }

	public byte EmoteId { get; set; }

	public EmotePlayErrorMessage() {}


	public EmotePlayErrorMessage InitEmotePlayErrorMessage(byte EmoteId)
	{
		this.EmoteId = EmoteId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.EmoteId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.EmoteId = reader.ReadByte();
	}
}
}
