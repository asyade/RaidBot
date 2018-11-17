using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismSetSabotagedRequestMessage : NetworkMessage
{

	public const uint Id = 6468;
	public override uint MessageId { get { return Id; } }

	public short SubAreaId { get; set; }

	public PrismSetSabotagedRequestMessage() {}


	public PrismSetSabotagedRequestMessage InitPrismSetSabotagedRequestMessage(short SubAreaId)
	{
		this.SubAreaId = SubAreaId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SubAreaId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SubAreaId = reader.ReadVarShort();
	}
}
}
