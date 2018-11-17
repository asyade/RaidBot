using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ClientKeyMessage : NetworkMessage
{

	public const uint Id = 5607;
	public override uint MessageId { get { return Id; } }

	public String Key { get; set; }

	public ClientKeyMessage() {}


	public ClientKeyMessage InitClientKeyMessage(String Key)
	{
		this.Key = Key;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Key);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Key = reader.ReadUTF();
	}
}
}
