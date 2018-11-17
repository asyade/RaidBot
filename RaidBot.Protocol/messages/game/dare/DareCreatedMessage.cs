using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DareCreatedMessage : NetworkMessage
{

	public const uint Id = 6668;
	public override uint MessageId { get { return Id; } }

	public DareInformations DareInfos { get; set; }
	public bool NeedNotifications { get; set; }

	public DareCreatedMessage() {}


	public DareCreatedMessage InitDareCreatedMessage(DareInformations DareInfos, bool NeedNotifications)
	{
		this.DareInfos = DareInfos;
		this.NeedNotifications = NeedNotifications;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.DareInfos.Serialize(writer);
		writer.WriteBoolean(this.NeedNotifications);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DareInfos = new DareInformations();
		this.DareInfos.Deserialize(reader);
		this.NeedNotifications = reader.ReadBoolean();
	}
}
}
