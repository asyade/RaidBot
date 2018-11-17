using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ContactLookErrorMessage : NetworkMessage
{

	public const uint Id = 6045;
	public override uint MessageId { get { return Id; } }

	public int RequestId { get; set; }

	public ContactLookErrorMessage() {}


	public ContactLookErrorMessage InitContactLookErrorMessage(int RequestId)
	{
		this.RequestId = RequestId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.RequestId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.RequestId = reader.ReadVarInt();
	}
}
}
