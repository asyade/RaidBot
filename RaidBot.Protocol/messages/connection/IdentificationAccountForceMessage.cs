using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class IdentificationAccountForceMessage : IdentificationMessage
{

	public const uint Id = 6119;
	public override uint MessageId { get { return Id; } }

	public String ForcedAccountLogin { get; set; }

	public IdentificationAccountForceMessage() {}


	public IdentificationAccountForceMessage InitIdentificationAccountForceMessage(String ForcedAccountLogin)
	{
		this.ForcedAccountLogin = ForcedAccountLogin;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.ForcedAccountLogin);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.ForcedAccountLogin = reader.ReadUTF();
	}
}
}
