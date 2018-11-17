using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ContactLookRequestMessage : NetworkMessage
{

	public const uint Id = 5932;
	public override uint MessageId { get { return Id; } }

	public byte RequestId { get; set; }
	public byte ContactType { get; set; }

	public ContactLookRequestMessage() {}


	public ContactLookRequestMessage InitContactLookRequestMessage(byte RequestId, byte ContactType)
	{
		this.RequestId = RequestId;
		this.ContactType = ContactType;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.RequestId);
		writer.WriteByte(this.ContactType);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.RequestId = reader.ReadByte();
		this.ContactType = reader.ReadByte();
	}
}
}
