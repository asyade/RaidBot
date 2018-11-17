using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismFightDefenderAddMessage : NetworkMessage
{

	public const uint Id = 5895;
	public override uint MessageId { get { return Id; } }

	public short SubAreaId { get; set; }
	public short FightId { get; set; }

	public PrismFightDefenderAddMessage() {}


	public PrismFightDefenderAddMessage InitPrismFightDefenderAddMessage(short SubAreaId, short FightId)
	{
		this.SubAreaId = SubAreaId;
		this.FightId = FightId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteVarShort(this.FightId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SubAreaId = reader.ReadVarShort();
		this.FightId = reader.ReadVarShort();
	}
}
}
