using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightCastOnTargetRequestMessage : NetworkMessage
{

	public const uint Id = 6330;
	public override uint MessageId { get { return Id; } }

	public short SpellId { get; set; }
	public double TargetId { get; set; }

	public GameActionFightCastOnTargetRequestMessage() {}


	public GameActionFightCastOnTargetRequestMessage InitGameActionFightCastOnTargetRequestMessage(short SpellId, double TargetId)
	{
		this.SpellId = SpellId;
		this.TargetId = TargetId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SpellId);
		writer.WriteDouble(this.TargetId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SpellId = reader.ReadVarShort();
		this.TargetId = reader.ReadDouble();
	}
}
}
