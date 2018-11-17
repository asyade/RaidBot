using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayTreasureHintInformations : GameRolePlayActorInformations
{

	public const uint Id = 471;
	public override uint MessageId { get { return Id; } }

	public short NpcId { get; set; }

	public GameRolePlayTreasureHintInformations() {}


	public GameRolePlayTreasureHintInformations InitGameRolePlayTreasureHintInformations(short NpcId)
	{
		this.NpcId = NpcId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.NpcId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.NpcId = reader.ReadVarShort();
	}
}
}
