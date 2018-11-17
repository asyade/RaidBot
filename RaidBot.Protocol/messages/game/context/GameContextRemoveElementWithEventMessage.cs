using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameContextRemoveElementWithEventMessage : GameContextRemoveElementMessage
{

	public const uint Id = 6412;
	public override uint MessageId { get { return Id; } }

	public byte ElementEventId { get; set; }

	public GameContextRemoveElementWithEventMessage() {}


	public GameContextRemoveElementWithEventMessage InitGameContextRemoveElementWithEventMessage(byte ElementEventId)
	{
		this.ElementEventId = ElementEventId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.ElementEventId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.ElementEventId = reader.ReadByte();
	}
}
}
