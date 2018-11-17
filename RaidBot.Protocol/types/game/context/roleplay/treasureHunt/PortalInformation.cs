using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PortalInformation : NetworkType
{

	public const uint Id = 466;
	public override uint MessageId { get { return Id; } }

	public int PortalId { get; set; }
	public short AreaId { get; set; }

	public PortalInformation() {}


	public PortalInformation InitPortalInformation(int PortalId, short AreaId)
	{
		this.PortalId = PortalId;
		this.AreaId = AreaId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.PortalId);
		writer.WriteShort(this.AreaId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PortalId = reader.ReadInt();
		this.AreaId = reader.ReadShort();
	}
}
}
