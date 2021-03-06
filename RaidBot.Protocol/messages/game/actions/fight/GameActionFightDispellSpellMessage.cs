using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightDispellSpellMessage : GameActionFightDispellMessage
{

	public const uint Id = 6176;
	public override uint MessageId { get { return Id; } }

	public short SpellId { get; set; }

	public GameActionFightDispellSpellMessage() {}


	public GameActionFightDispellSpellMessage InitGameActionFightDispellSpellMessage(short SpellId)
	{
		this.SpellId = SpellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.SpellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.SpellId = reader.ReadVarShort();
	}
}
}
