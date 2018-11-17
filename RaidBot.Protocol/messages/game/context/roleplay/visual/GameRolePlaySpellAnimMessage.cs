using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlaySpellAnimMessage : NetworkMessage
{

	public const uint Id = 6114;
	public override uint MessageId { get { return Id; } }

	public long CasterId { get; set; }
	public short TargetCellId { get; set; }
	public short SpellId { get; set; }
	public short SpellLevel { get; set; }

	public GameRolePlaySpellAnimMessage() {}


	public GameRolePlaySpellAnimMessage InitGameRolePlaySpellAnimMessage(long CasterId, short TargetCellId, short SpellId, short SpellLevel)
	{
		this.CasterId = CasterId;
		this.TargetCellId = TargetCellId;
		this.SpellId = SpellId;
		this.SpellLevel = SpellLevel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.CasterId);
		writer.WriteVarShort(this.TargetCellId);
		writer.WriteVarShort(this.SpellId);
		writer.WriteShort(this.SpellLevel);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CasterId = reader.ReadVarLong();
		this.TargetCellId = reader.ReadVarShort();
		this.SpellId = reader.ReadVarShort();
		this.SpellLevel = reader.ReadShort();
	}
}
}
