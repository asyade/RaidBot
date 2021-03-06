using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameContextCreateMessage : NetworkMessage
{

	public const uint Id = 200;
	public override uint MessageId { get { return Id; } }

	public byte Context { get; set; }

	public GameContextCreateMessage() {}


	public GameContextCreateMessage InitGameContextCreateMessage(byte Context)
	{
		this.Context = Context;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Context);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Context = reader.ReadByte();
	}
}
}
