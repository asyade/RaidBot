using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CheckFileRequestMessage : NetworkMessage
{

	public const uint Id = 6154;
	public override uint MessageId { get { return Id; } }

	public String Filename { get; set; }
	public byte Type { get; set; }

	public CheckFileRequestMessage() {}


	public CheckFileRequestMessage InitCheckFileRequestMessage(String Filename, byte Type)
	{
		this.Filename = Filename;
		this.Type = Type;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Filename);
		writer.WriteByte(this.Type);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Filename = reader.ReadUTF();
		this.Type = reader.ReadByte();
	}
}
}
