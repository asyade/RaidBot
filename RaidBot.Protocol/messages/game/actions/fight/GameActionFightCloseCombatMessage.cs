using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightCloseCombatMessage : AbstractGameActionFightTargetedAbilityMessage
{

	public const uint Id = 6116;
	public override uint MessageId { get { return Id; } }

	public short WeaponGenericId { get; set; }

	public GameActionFightCloseCombatMessage() {}


	public GameActionFightCloseCombatMessage InitGameActionFightCloseCombatMessage(short WeaponGenericId)
	{
		this.WeaponGenericId = WeaponGenericId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.WeaponGenericId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.WeaponGenericId = reader.ReadVarShort();
	}
}
}
