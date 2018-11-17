using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AbstractFightDispellableEffect : NetworkType
{

	public const uint Id = 206;
	public override uint MessageId { get { return Id; } }

	public int Uid { get; set; }
	public double TargetId { get; set; }
	public short TurnDuration { get; set; }
	public byte Dispelable { get; set; }
	public short SpellId { get; set; }
	public int EffectId { get; set; }
	public int ParentBoostUid { get; set; }

	public AbstractFightDispellableEffect() {}


	public AbstractFightDispellableEffect InitAbstractFightDispellableEffect(int Uid, double TargetId, short TurnDuration, byte Dispelable, short SpellId, int EffectId, int ParentBoostUid)
	{
		this.Uid = Uid;
		this.TargetId = TargetId;
		this.TurnDuration = TurnDuration;
		this.Dispelable = Dispelable;
		this.SpellId = SpellId;
		this.EffectId = EffectId;
		this.ParentBoostUid = ParentBoostUid;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.Uid);
		writer.WriteDouble(this.TargetId);
		writer.WriteShort(this.TurnDuration);
		writer.WriteByte(this.Dispelable);
		writer.WriteVarShort(this.SpellId);
		writer.WriteVarInt(this.EffectId);
		writer.WriteVarInt(this.ParentBoostUid);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Uid = reader.ReadVarInt();
		this.TargetId = reader.ReadDouble();
		this.TurnDuration = reader.ReadShort();
		this.Dispelable = reader.ReadByte();
		this.SpellId = reader.ReadVarShort();
		this.EffectId = reader.ReadVarInt();
		this.ParentBoostUid = reader.ReadVarInt();
	}
}
}
