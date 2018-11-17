using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ClientUIOpenedByObjectMessage : ClientUIOpenedMessage
{

	public const uint Id = 6463;
	public override uint MessageId { get { return Id; } }

	public int Uid { get; set; }

	public ClientUIOpenedByObjectMessage() {}


	public ClientUIOpenedByObjectMessage InitClientUIOpenedByObjectMessage(int Uid)
	{
		this.Uid = Uid;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.Uid);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Uid = reader.ReadVarInt();
	}
}
}
