using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HelloConnectMessage : NetworkMessage
{

	public const uint Id = 3;
	public override uint MessageId { get { return Id; } }

	public String Salt { get; set; }
	public byte[] Key { get; set; }

	public HelloConnectMessage() {}


	public HelloConnectMessage InitHelloConnectMessage(String Salt, byte[] Key)
	{
		this.Salt = Salt;
		this.Key = Key;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Salt);
		writer.WriteVarInt(this.Key.Length);
		foreach (byte item in this.Key)
		{
			writer.WriteByte(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Salt = reader.ReadUTF();
		int KeyLen = reader.ReadVarInt();
		Key = new byte[KeyLen];
		for (int i = 0; i < KeyLen; i++)
		{
			this.Key[i] = reader.ReadByte();
		}
	}
}
}
