using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectEffectMount : ObjectEffect
{

	public const uint Id = 179;
	public override uint MessageId { get { return Id; } }

	public bool Sex { get; set; }
	public bool IsRideable { get; set; }
	public bool IsFeconded { get; set; }
	public bool IsFecondationReady { get; set; }
	public long Id_ { get; set; }
	public long ExpirationDate { get; set; }
	public int Model { get; set; }
	public String Name { get; set; }
	public String Owner { get; set; }
	public byte Level { get; set; }
	public int ReproductionCount { get; set; }
	public int ReproductionCountMax { get; set; }
	public ObjectEffectInteger[] Effects { get; set; }
	public int[] Capacities { get; set; }

	public ObjectEffectMount() {}


	public ObjectEffectMount InitObjectEffectMount(bool Sex, bool IsRideable, bool IsFeconded, bool IsFecondationReady, long Id_, long ExpirationDate, int Model, String Name, String Owner, byte Level, int ReproductionCount, int ReproductionCountMax, ObjectEffectInteger[] Effects, int[] Capacities)
	{
		this.Sex = Sex;
		this.IsRideable = IsRideable;
		this.IsFeconded = IsFeconded;
		this.IsFecondationReady = IsFecondationReady;
		this.Id_ = Id_;
		this.ExpirationDate = ExpirationDate;
		this.Model = Model;
		this.Name = Name;
		this.Owner = Owner;
		this.Level = Level;
		this.ReproductionCount = ReproductionCount;
		this.ReproductionCountMax = ReproductionCountMax;
		this.Effects = Effects;
		this.Capacities = Capacities;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, Sex);
		box = BooleanByteWrapper.SetFlag(box, 1, IsRideable);
		box = BooleanByteWrapper.SetFlag(box, 2, IsFeconded);
		box = BooleanByteWrapper.SetFlag(box, 3, IsFecondationReady);
		writer.WriteByte(box);
		writer.WriteVarLong(this.Id_);
		writer.WriteVarLong(this.ExpirationDate);
		writer.WriteVarInt(this.Model);
		writer.WriteUTF(this.Name);
		writer.WriteUTF(this.Owner);
		writer.WriteByte(this.Level);
		writer.WriteVarInt(this.ReproductionCount);
		writer.WriteVarInt(this.ReproductionCountMax);
		writer.WriteShort(this.Effects.Length);
		foreach (ObjectEffectInteger item in this.Effects)
		{
			item.Serialize(writer);
		}
		writer.WriteShort(this.Capacities.Length);
		foreach (int item in this.Capacities)
		{
			writer.WriteVarInt(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		byte box = reader.ReadByte();
		this.Sex = BooleanByteWrapper.GetFlag(box, 0);
		this.IsRideable = BooleanByteWrapper.GetFlag(box, 1);
		this.IsFeconded = BooleanByteWrapper.GetFlag(box, 2);
		this.IsFecondationReady = BooleanByteWrapper.GetFlag(box, 3);
		this.Id_ = reader.ReadVarLong();
		this.ExpirationDate = reader.ReadVarLong();
		this.Model = reader.ReadVarInt();
		this.Name = reader.ReadUTF();
		this.Owner = reader.ReadUTF();
		this.Level = reader.ReadByte();
		this.ReproductionCount = reader.ReadVarInt();
		this.ReproductionCountMax = reader.ReadVarInt();
		int EffectsLen = reader.ReadShort();
		Effects = new ObjectEffectInteger[EffectsLen];
		for (int i = 0; i < EffectsLen; i++)
		{
			this.Effects[i] = new ObjectEffectInteger();
			this.Effects[i].Deserialize(reader);
		}
		int CapacitiesLen = reader.ReadShort();
		Capacities = new int[CapacitiesLen];
		for (int i = 0; i < CapacitiesLen; i++)
		{
			this.Capacities[i] = reader.ReadVarInt();
		}
	}
}
}
