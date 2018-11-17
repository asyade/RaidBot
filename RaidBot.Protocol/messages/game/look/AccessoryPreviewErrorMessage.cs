using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AccessoryPreviewErrorMessage : NetworkMessage
{

	public const uint Id = 6521;
	public override uint MessageId { get { return Id; } }

	public byte Error { get; set; }

	public AccessoryPreviewErrorMessage() {}


	public AccessoryPreviewErrorMessage InitAccessoryPreviewErrorMessage(byte Error)
	{
		this.Error = Error;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Error);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Error = reader.ReadByte();
	}
}
}
