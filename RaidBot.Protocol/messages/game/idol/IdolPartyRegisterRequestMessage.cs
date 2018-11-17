using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class IdolPartyRegisterRequestMessage : NetworkMessage
{

	public const uint Id = 6582;
	public override uint MessageId { get { return Id; } }

	public bool Register { get; set; }

	public IdolPartyRegisterRequestMessage() {}


	public IdolPartyRegisterRequestMessage InitIdolPartyRegisterRequestMessage(bool Register)
	{
		this.Register = Register;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Register);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Register = reader.ReadBoolean();
	}
}
}
