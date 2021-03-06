using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightResumeMessage : GameFightSpectateMessage
{

	public const uint Id = 6067;
	public override uint MessageId { get { return Id; } }

	public GameFightSpellCooldown[] SpellCooldowns { get; set; }
	public byte SummonCount { get; set; }
	public byte BombCount { get; set; }

	public GameFightResumeMessage() {}


	public GameFightResumeMessage InitGameFightResumeMessage(GameFightSpellCooldown[] SpellCooldowns, byte SummonCount, byte BombCount)
	{
		this.SpellCooldowns = SpellCooldowns;
		this.SummonCount = SummonCount;
		this.BombCount = BombCount;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.SpellCooldowns.Length);
		foreach (GameFightSpellCooldown item in this.SpellCooldowns)
		{
			item.Serialize(writer);
		}
		writer.WriteByte(this.SummonCount);
		writer.WriteByte(this.BombCount);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		int SpellCooldownsLen = reader.ReadShort();
		SpellCooldowns = new GameFightSpellCooldown[SpellCooldownsLen];
		for (int i = 0; i < SpellCooldownsLen; i++)
		{
			this.SpellCooldowns[i] = new GameFightSpellCooldown();
			this.SpellCooldowns[i].Deserialize(reader);
		}
		this.SummonCount = reader.ReadByte();
		this.BombCount = reader.ReadByte();
	}
}
}
