using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightTemporaryBoostWeaponDamagesEffect : FightTemporaryBoostEffect
{

	public const uint Id = 211;
	public override uint MessageId { get { return Id; } }

	public short WeaponTypeId { get; set; }

	public FightTemporaryBoostWeaponDamagesEffect() {}


	public FightTemporaryBoostWeaponDamagesEffect InitFightTemporaryBoostWeaponDamagesEffect(short WeaponTypeId)
	{
		this.WeaponTypeId = WeaponTypeId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.WeaponTypeId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.WeaponTypeId = reader.ReadShort();
	}
}
}
