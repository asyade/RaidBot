using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MountClientData : NetworkType
{

	public const uint Id = 178;
	public override uint MessageId { get { return Id; } }

	public bool Sex { get; set; }
	public bool IsRideable { get; set; }
	public bool IsWild { get; set; }
	public bool IsFecondationReady { get; set; }
	public bool UseHarnessColors { get; set; }
	public double Id_ { get; set; }
	public int Model { get; set; }
	public int[] Ancestor { get; set; }
	public int[] Behaviors { get; set; }
	public String Name { get; set; }
	public int OwnerId { get; set; }
	public long Experience { get; set; }
	public long ExperienceForLevel { get; set; }
	public double ExperienceForNextLevel { get; set; }
	public byte Level { get; set; }
	public int MaxPods { get; set; }
	public int Stamina { get; set; }
	public int StaminaMax { get; set; }
	public int Maturity { get; set; }
	public int MaturityForAdult { get; set; }
	public int Energy { get; set; }
	public int EnergyMax { get; set; }
	public int Serenity { get; set; }
	public int AggressivityMax { get; set; }
	public int SerenityMax { get; set; }
	public int Love { get; set; }
	public int LoveMax { get; set; }
	public int FecondationTime { get; set; }
	public int BoostLimiter { get; set; }
	public double BoostMax { get; set; }
	public int ReproductionCount { get; set; }
	public int ReproductionCountMax { get; set; }
	public short HarnessGID { get; set; }
	public ObjectEffectInteger[] EffectList { get; set; }

	public MountClientData() {}


	public MountClientData InitMountClientData(bool Sex, bool IsRideable, bool IsWild, bool IsFecondationReady, bool UseHarnessColors, double Id_, int Model, int[] Ancestor, int[] Behaviors, String Name, int OwnerId, long Experience, long ExperienceForLevel, double ExperienceForNextLevel, byte Level, int MaxPods, int Stamina, int StaminaMax, int Maturity, int MaturityForAdult, int Energy, int EnergyMax, int Serenity, int AggressivityMax, int SerenityMax, int Love, int LoveMax, int FecondationTime, int BoostLimiter, double BoostMax, int ReproductionCount, int ReproductionCountMax, short HarnessGID, ObjectEffectInteger[] EffectList)
	{
		this.Sex = Sex;
		this.IsRideable = IsRideable;
		this.IsWild = IsWild;
		this.IsFecondationReady = IsFecondationReady;
		this.UseHarnessColors = UseHarnessColors;
		this.Id_ = Id_;
		this.Model = Model;
		this.Ancestor = Ancestor;
		this.Behaviors = Behaviors;
		this.Name = Name;
		this.OwnerId = OwnerId;
		this.Experience = Experience;
		this.ExperienceForLevel = ExperienceForLevel;
		this.ExperienceForNextLevel = ExperienceForNextLevel;
		this.Level = Level;
		this.MaxPods = MaxPods;
		this.Stamina = Stamina;
		this.StaminaMax = StaminaMax;
		this.Maturity = Maturity;
		this.MaturityForAdult = MaturityForAdult;
		this.Energy = Energy;
		this.EnergyMax = EnergyMax;
		this.Serenity = Serenity;
		this.AggressivityMax = AggressivityMax;
		this.SerenityMax = SerenityMax;
		this.Love = Love;
		this.LoveMax = LoveMax;
		this.FecondationTime = FecondationTime;
		this.BoostLimiter = BoostLimiter;
		this.BoostMax = BoostMax;
		this.ReproductionCount = ReproductionCount;
		this.ReproductionCountMax = ReproductionCountMax;
		this.HarnessGID = HarnessGID;
		this.EffectList = EffectList;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, Sex);
		box = BooleanByteWrapper.SetFlag(box, 1, IsRideable);
		box = BooleanByteWrapper.SetFlag(box, 2, IsWild);
		box = BooleanByteWrapper.SetFlag(box, 3, IsFecondationReady);
		box = BooleanByteWrapper.SetFlag(box, 4, UseHarnessColors);
		writer.WriteByte(box);
		writer.WriteDouble(this.Id_);
		writer.WriteVarInt(this.Model);
		writer.WriteShort(this.Ancestor.Length);
		foreach (int item in this.Ancestor)
		{
			writer.WriteInt(item);
		}
		writer.WriteShort(this.Behaviors.Length);
		foreach (int item in this.Behaviors)
		{
			writer.WriteInt(item);
		}
		writer.WriteUTF(this.Name);
		writer.WriteInt(this.OwnerId);
		writer.WriteVarLong(this.Experience);
		writer.WriteVarLong(this.ExperienceForLevel);
		writer.WriteDouble(this.ExperienceForNextLevel);
		writer.WriteByte(this.Level);
		writer.WriteVarInt(this.MaxPods);
		writer.WriteVarInt(this.Stamina);
		writer.WriteVarInt(this.StaminaMax);
		writer.WriteVarInt(this.Maturity);
		writer.WriteVarInt(this.MaturityForAdult);
		writer.WriteVarInt(this.Energy);
		writer.WriteVarInt(this.EnergyMax);
		writer.WriteInt(this.Serenity);
		writer.WriteInt(this.AggressivityMax);
		writer.WriteVarInt(this.SerenityMax);
		writer.WriteVarInt(this.Love);
		writer.WriteVarInt(this.LoveMax);
		writer.WriteInt(this.FecondationTime);
		writer.WriteInt(this.BoostLimiter);
		writer.WriteDouble(this.BoostMax);
		writer.WriteInt(this.ReproductionCount);
		writer.WriteVarInt(this.ReproductionCountMax);
		writer.WriteVarShort(this.HarnessGID);
		writer.WriteShort(this.EffectList.Length);
		foreach (ObjectEffectInteger item in this.EffectList)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		byte box = reader.ReadByte();
		this.Sex = BooleanByteWrapper.GetFlag(box, 0);
		this.IsRideable = BooleanByteWrapper.GetFlag(box, 1);
		this.IsWild = BooleanByteWrapper.GetFlag(box, 2);
		this.IsFecondationReady = BooleanByteWrapper.GetFlag(box, 3);
		this.UseHarnessColors = BooleanByteWrapper.GetFlag(box, 4);
		this.Id_ = reader.ReadDouble();
		this.Model = reader.ReadVarInt();
		int AncestorLen = reader.ReadShort();
		Ancestor = new int[AncestorLen];
		for (int i = 0; i < AncestorLen; i++)
		{
			this.Ancestor[i] = reader.ReadInt();
		}
		int BehaviorsLen = reader.ReadShort();
		Behaviors = new int[BehaviorsLen];
		for (int i = 0; i < BehaviorsLen; i++)
		{
			this.Behaviors[i] = reader.ReadInt();
		}
		this.Name = reader.ReadUTF();
		this.OwnerId = reader.ReadInt();
		this.Experience = reader.ReadVarLong();
		this.ExperienceForLevel = reader.ReadVarLong();
		this.ExperienceForNextLevel = reader.ReadDouble();
		this.Level = reader.ReadByte();
		this.MaxPods = reader.ReadVarInt();
		this.Stamina = reader.ReadVarInt();
		this.StaminaMax = reader.ReadVarInt();
		this.Maturity = reader.ReadVarInt();
		this.MaturityForAdult = reader.ReadVarInt();
		this.Energy = reader.ReadVarInt();
		this.EnergyMax = reader.ReadVarInt();
		this.Serenity = reader.ReadInt();
		this.AggressivityMax = reader.ReadInt();
		this.SerenityMax = reader.ReadVarInt();
		this.Love = reader.ReadVarInt();
		this.LoveMax = reader.ReadVarInt();
		this.FecondationTime = reader.ReadInt();
		this.BoostLimiter = reader.ReadInt();
		this.BoostMax = reader.ReadDouble();
		this.ReproductionCount = reader.ReadInt();
		this.ReproductionCountMax = reader.ReadVarInt();
		this.HarnessGID = reader.ReadVarShort();
		int EffectListLen = reader.ReadShort();
		EffectList = new ObjectEffectInteger[EffectListLen];
		for (int i = 0; i < EffectListLen; i++)
		{
			this.EffectList[i] = new ObjectEffectInteger();
			this.EffectList[i].Deserialize(reader);
		}
	}
}
}
