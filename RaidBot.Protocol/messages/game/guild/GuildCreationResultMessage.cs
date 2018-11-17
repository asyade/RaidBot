using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildCreationResultMessage : NetworkMessage
{

	public const uint Id = 5554;
	public override uint MessageId { get { return Id; } }

	public byte Result { get; set; }

	public GuildCreationResultMessage() {}


	public GuildCreationResultMessage InitGuildCreationResultMessage(byte Result)
	{
		this.Result = Result;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Result);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Result = reader.ReadByte();
	}
}
}
