using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HaapiSessionMessage : NetworkMessage
{

	public const uint Id = 6769;
	public override uint MessageId { get { return Id; } }

	public String Key { get; set; }
	public byte Type { get; set; }

	public HaapiSessionMessage() {}


	public HaapiSessionMessage InitHaapiSessionMessage(String Key, byte Type)
	{
		this.Key = Key;
		this.Type = Type;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Key);
		writer.WriteByte(this.Type);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Key = reader.ReadUTF();
		this.Type = reader.ReadByte();
	}
}
}
