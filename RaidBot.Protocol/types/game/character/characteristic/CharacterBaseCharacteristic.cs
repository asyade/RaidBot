using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterBaseCharacteristic : NetworkType
{

	public const uint Id = 4;
	public override uint MessageId { get { return Id; } }

	public short Base { get; set; }
	public short Additionnal { get; set; }
	public short ObjectsAndMountBonus { get; set; }
	public short AlignGiftBonus { get; set; }
	public short ContextModif { get; set; }

	public CharacterBaseCharacteristic() {}


	public CharacterBaseCharacteristic InitCharacterBaseCharacteristic(short Base, short Additionnal, short ObjectsAndMountBonus, short AlignGiftBonus, short ContextModif)
	{
		this.Base = Base;
		this.Additionnal = Additionnal;
		this.ObjectsAndMountBonus = ObjectsAndMountBonus;
		this.AlignGiftBonus = AlignGiftBonus;
		this.ContextModif = ContextModif;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.Base);
		writer.WriteVarShort(this.Additionnal);
		writer.WriteVarShort(this.ObjectsAndMountBonus);
		writer.WriteVarShort(this.AlignGiftBonus);
		writer.WriteVarShort(this.ContextModif);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Base = reader.ReadVarShort();
		this.Additionnal = reader.ReadVarShort();
		this.ObjectsAndMountBonus = reader.ReadVarShort();
		this.AlignGiftBonus = reader.ReadVarShort();
		this.ContextModif = reader.ReadVarShort();
	}
}
}
