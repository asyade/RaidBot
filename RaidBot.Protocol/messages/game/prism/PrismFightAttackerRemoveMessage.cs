using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismFightAttackerRemoveMessage : NetworkMessage
{

	public const uint Id = 5897;
	public override uint MessageId { get { return Id; } }

	public short SubAreaId { get; set; }
	public short FightId { get; set; }
	public long FighterToRemoveId { get; set; }

	public PrismFightAttackerRemoveMessage() {}


	public PrismFightAttackerRemoveMessage InitPrismFightAttackerRemoveMessage(short SubAreaId, short FightId, long FighterToRemoveId)
	{
		this.SubAreaId = SubAreaId;
		this.FightId = FightId;
		this.FighterToRemoveId = FighterToRemoveId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteVarShort(this.FightId);
		writer.WriteVarLong(this.FighterToRemoveId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SubAreaId = reader.ReadVarShort();
		this.FightId = reader.ReadVarShort();
		this.FighterToRemoveId = reader.ReadVarLong();
	}
}
}
