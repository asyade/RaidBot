using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class RemodelingInformation : NetworkType
{

	public const uint Id = 480;
	public override uint MessageId { get { return Id; } }

	public String Name { get; set; }
	public byte Breed { get; set; }
	public bool Sex { get; set; }
	public short CosmeticId { get; set; }
	public int[] Colors { get; set; }

	public RemodelingInformation() {}


	public RemodelingInformation InitRemodelingInformation(String Name, byte Breed, bool Sex, short CosmeticId, int[] Colors)
	{
		this.Name = Name;
		this.Breed = Breed;
		this.Sex = Sex;
		this.CosmeticId = CosmeticId;
		this.Colors = Colors;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Name);
		writer.WriteByte(this.Breed);
		writer.WriteBoolean(this.Sex);
		writer.WriteVarShort(this.CosmeticId);
		writer.WriteShort(this.Colors.Length);
		foreach (int item in this.Colors)
		{
			writer.WriteInt(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Name = reader.ReadUTF();
		this.Breed = reader.ReadByte();
		this.Sex = reader.ReadBoolean();
		this.CosmeticId = reader.ReadVarShort();
		int ColorsLen = reader.ReadShort();
		Colors = new int[ColorsLen];
		for (int i = 0; i < ColorsLen; i++)
		{
			this.Colors[i] = reader.ReadInt();
		}
	}
}
}
