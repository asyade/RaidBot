using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayTaxCollectorInformations : GameRolePlayActorInformations
{

	public const uint Id = 148;
	public override uint MessageId { get { return Id; } }

	public byte GuildLevel { get; set; }
	public int TaxCollectorAttack { get; set; }

	public GameRolePlayTaxCollectorInformations() {}


	public GameRolePlayTaxCollectorInformations InitGameRolePlayTaxCollectorInformations(byte GuildLevel, int TaxCollectorAttack)
	{
		this.GuildLevel = GuildLevel;
		this.TaxCollectorAttack = TaxCollectorAttack;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.GuildLevel);
		writer.WriteInt(this.TaxCollectorAttack);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.GuildLevel = reader.ReadByte();
		this.TaxCollectorAttack = reader.ReadInt();
	}
}
}
