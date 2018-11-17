using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SlaveSwitchContextMessage : NetworkMessage
{

	public const uint Id = 6214;
	public override uint MessageId { get { return Id; } }

	public double MasterId { get; set; }
	public double SlaveId { get; set; }
	public SpellItem[] SlaveSpells { get; set; }
	public CharacterCharacteristicsInformations SlaveStats { get; set; }
	public Shortcut[] Shortcuts { get; set; }

	public SlaveSwitchContextMessage() {}


	public SlaveSwitchContextMessage InitSlaveSwitchContextMessage(double MasterId, double SlaveId, SpellItem[] SlaveSpells, CharacterCharacteristicsInformations SlaveStats, Shortcut[] Shortcuts)
	{
		this.MasterId = MasterId;
		this.SlaveId = SlaveId;
		this.SlaveSpells = SlaveSpells;
		this.SlaveStats = SlaveStats;
		this.Shortcuts = Shortcuts;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.MasterId);
		writer.WriteDouble(this.SlaveId);
		writer.WriteShort(this.SlaveSpells.Length);
		foreach (SpellItem item in this.SlaveSpells)
		{
			item.Serialize(writer);
		}
		this.SlaveStats.Serialize(writer);
		writer.WriteShort(this.Shortcuts.Length);
		foreach (Shortcut item in this.Shortcuts)
		{
			writer.WriteShort(item.MessageId);
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MasterId = reader.ReadDouble();
		this.SlaveId = reader.ReadDouble();
		int SlaveSpellsLen = reader.ReadShort();
		SlaveSpells = new SpellItem[SlaveSpellsLen];
		for (int i = 0; i < SlaveSpellsLen; i++)
		{
			this.SlaveSpells[i] = new SpellItem();
			this.SlaveSpells[i].Deserialize(reader);
		}
		this.SlaveStats = new CharacterCharacteristicsInformations();
		this.SlaveStats.Deserialize(reader);
		int ShortcutsLen = reader.ReadShort();
		Shortcuts = new Shortcut[ShortcutsLen];
		for (int i = 0; i < ShortcutsLen; i++)
		{
			this.Shortcuts[i] = ProtocolTypeManager.GetInstance<Shortcut>(reader.ReadShort());
			this.Shortcuts[i].Deserialize(reader);
		}
	}
}
}
