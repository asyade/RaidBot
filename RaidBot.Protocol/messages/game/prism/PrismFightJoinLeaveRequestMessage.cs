using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismFightJoinLeaveRequestMessage : NetworkMessage
{

	public const uint Id = 5843;
	public override uint MessageId { get { return Id; } }

	public short SubAreaId { get; set; }
	public bool Join { get; set; }

	public PrismFightJoinLeaveRequestMessage() {}


	public PrismFightJoinLeaveRequestMessage InitPrismFightJoinLeaveRequestMessage(short SubAreaId, bool Join)
	{
		this.SubAreaId = SubAreaId;
		this.Join = Join;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteBoolean(this.Join);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SubAreaId = reader.ReadVarShort();
		this.Join = reader.ReadBoolean();
	}
}
}
