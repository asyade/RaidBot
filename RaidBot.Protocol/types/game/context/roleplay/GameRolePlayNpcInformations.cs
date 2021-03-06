using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayNpcInformations : GameRolePlayActorInformations
{

	public const uint Id = 156;
	public override uint MessageId { get { return Id; } }

	public short NpcId { get; set; }
	public bool Sex { get; set; }
	public short SpecialArtworkId { get; set; }

	public GameRolePlayNpcInformations() {}


	public GameRolePlayNpcInformations InitGameRolePlayNpcInformations(short NpcId, bool Sex, short SpecialArtworkId)
	{
		this.NpcId = NpcId;
		this.Sex = Sex;
		this.SpecialArtworkId = SpecialArtworkId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.NpcId);
		writer.WriteBoolean(this.Sex);
		writer.WriteVarShort(this.SpecialArtworkId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.NpcId = reader.ReadVarShort();
		this.Sex = reader.ReadBoolean();
		this.SpecialArtworkId = reader.ReadVarShort();
	}
}
}
