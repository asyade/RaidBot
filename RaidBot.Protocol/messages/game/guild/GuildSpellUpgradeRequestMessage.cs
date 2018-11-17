using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildSpellUpgradeRequestMessage : NetworkMessage
{

	public const uint Id = 5699;
	public override uint MessageId { get { return Id; } }

	public int SpellId { get; set; }

	public GuildSpellUpgradeRequestMessage() {}


	public GuildSpellUpgradeRequestMessage InitGuildSpellUpgradeRequestMessage(int SpellId)
	{
		this.SpellId = SpellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.SpellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SpellId = reader.ReadInt();
	}
}
}
