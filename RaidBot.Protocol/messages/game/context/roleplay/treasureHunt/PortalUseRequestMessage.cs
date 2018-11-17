using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PortalUseRequestMessage : NetworkMessage
{

	public const uint Id = 6492;
	public override uint MessageId { get { return Id; } }

	public int PortalId { get; set; }

	public PortalUseRequestMessage() {}


	public PortalUseRequestMessage InitPortalUseRequestMessage(int PortalId)
	{
		this.PortalId = PortalId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.PortalId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PortalId = reader.ReadVarInt();
	}
}
}
