using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterCharacteristicsInformations : NetworkType
{

	public const uint Id = 8;
	public override uint MessageId { get { return Id; } }

	public long Experience { get; set; }
	public long ExperienceLevelFloor { get; set; }
	public long ExperienceNextLevelFloor { get; set; }
	public long ExperienceBonusLimit { get; set; }
	public long Kamas { get; set; }
	public short StatsPoints { get; set; }
	public short AdditionnalPoints { get; set; }
	public short SpellsPoints { get; set; }
	public ActorExtendedAlignmentInformations AlignmentInfos { get; set; }
	public int LifePoints { get; set; }
	public int MaxLifePoints { get; set; }
	public short EnergyPoints { get; set; }
	public short MaxEnergyPoints { get; set; }
	public short ActionPointsCurrent { get; set; }
	public short MovementPointsCurrent { get; set; }
	public CharacterBaseCharacteristic Initiative { get; set; }
	public CharacterBaseCharacteristic Prospecting { get; set; }
	public CharacterBaseCharacteristic ActionPoints { get; set; }
	public CharacterBaseCharacteristic MovementPoints { get; set; }
	public CharacterBaseCharacteristic Strength { get; set; }
	public CharacterBaseCharacteristic Vitality { get; set; }
	public CharacterBaseCharacteristic Wisdom { get; set; }
	public CharacterBaseCharacteristic Chance { get; set; }
	public CharacterBaseCharacteristic Agility { get; set; }
	public CharacterBaseCharacteristic Intelligence { get; set; }
	public CharacterBaseCharacteristic Range { get; set; }
	public CharacterBaseCharacteristic SummonableCreaturesBoost { get; set; }
	public CharacterBaseCharacteristic Reflect { get; set; }
	public CharacterBaseCharacteristic CriticalHit { get; set; }
	public short CriticalHitWeapon { get; set; }
	public CharacterBaseCharacteristic CriticalMiss { get; set; }
	public CharacterBaseCharacteristic HealBonus { get; set; }
	public CharacterBaseCharacteristic AllDamagesBonus { get; set; }
	public CharacterBaseCharacteristic WeaponDamagesBonusPercent { get; set; }
	public CharacterBaseCharacteristic DamagesBonusPercent { get; set; }
	public CharacterBaseCharacteristic TrapBonus { get; set; }
	public CharacterBaseCharacteristic TrapBonusPercent { get; set; }
	public CharacterBaseCharacteristic GlyphBonusPercent { get; set; }
	public CharacterBaseCharacteristic RuneBonusPercent { get; set; }
	public CharacterBaseCharacteristic PermanentDamagePercent { get; set; }
	public CharacterBaseCharacteristic TackleBlock { get; set; }
	public CharacterBaseCharacteristic TackleEvade { get; set; }
	public CharacterBaseCharacteristic PAAttack { get; set; }
	public CharacterBaseCharacteristic PMAttack { get; set; }
	public CharacterBaseCharacteristic PushDamageBonus { get; set; }
	public CharacterBaseCharacteristic CriticalDamageBonus { get; set; }
	public CharacterBaseCharacteristic NeutralDamageBonus { get; set; }
	public CharacterBaseCharacteristic EarthDamageBonus { get; set; }
	public CharacterBaseCharacteristic WaterDamageBonus { get; set; }
	public CharacterBaseCharacteristic AirDamageBonus { get; set; }
	public CharacterBaseCharacteristic FireDamageBonus { get; set; }
	public CharacterBaseCharacteristic DodgePALostProbability { get; set; }
	public CharacterBaseCharacteristic DodgePMLostProbability { get; set; }
	public CharacterBaseCharacteristic NeutralElementResistPercent { get; set; }
	public CharacterBaseCharacteristic EarthElementResistPercent { get; set; }
	public CharacterBaseCharacteristic WaterElementResistPercent { get; set; }
	public CharacterBaseCharacteristic AirElementResistPercent { get; set; }
	public CharacterBaseCharacteristic FireElementResistPercent { get; set; }
	public CharacterBaseCharacteristic NeutralElementReduction { get; set; }
	public CharacterBaseCharacteristic EarthElementReduction { get; set; }
	public CharacterBaseCharacteristic WaterElementReduction { get; set; }
	public CharacterBaseCharacteristic AirElementReduction { get; set; }
	public CharacterBaseCharacteristic FireElementReduction { get; set; }
	public CharacterBaseCharacteristic PushDamageReduction { get; set; }
	public CharacterBaseCharacteristic CriticalDamageReduction { get; set; }
	public CharacterBaseCharacteristic PvpNeutralElementResistPercent { get; set; }
	public CharacterBaseCharacteristic PvpEarthElementResistPercent { get; set; }
	public CharacterBaseCharacteristic PvpWaterElementResistPercent { get; set; }
	public CharacterBaseCharacteristic PvpAirElementResistPercent { get; set; }
	public CharacterBaseCharacteristic PvpFireElementResistPercent { get; set; }
	public CharacterBaseCharacteristic PvpNeutralElementReduction { get; set; }
	public CharacterBaseCharacteristic PvpEarthElementReduction { get; set; }
	public CharacterBaseCharacteristic PvpWaterElementReduction { get; set; }
	public CharacterBaseCharacteristic PvpAirElementReduction { get; set; }
	public CharacterBaseCharacteristic PvpFireElementReduction { get; set; }
	public CharacterBaseCharacteristic MeleeDamageDonePercent { get; set; }
	public CharacterBaseCharacteristic MeleeDamageReceivedPercent { get; set; }
	public CharacterBaseCharacteristic RangedDamageDonePercent { get; set; }
	public CharacterBaseCharacteristic RangedDamageReceivedPercent { get; set; }
	public CharacterBaseCharacteristic WeaponDamageDonePercent { get; set; }
	public CharacterBaseCharacteristic WeaponDamageReceivedPercent { get; set; }
	public CharacterBaseCharacteristic SpellDamageDonePercent { get; set; }
	public CharacterBaseCharacteristic SpellDamageReceivedPercent { get; set; }
	public CharacterSpellModification[] SpellModifications { get; set; }
	public int ProbationTime { get; set; }

	public CharacterCharacteristicsInformations() {}


	public CharacterCharacteristicsInformations InitCharacterCharacteristicsInformations(long Experience, long ExperienceLevelFloor, long ExperienceNextLevelFloor, long ExperienceBonusLimit, long Kamas, short StatsPoints, short AdditionnalPoints, short SpellsPoints, ActorExtendedAlignmentInformations AlignmentInfos, int LifePoints, int MaxLifePoints, short EnergyPoints, short MaxEnergyPoints, short ActionPointsCurrent, short MovementPointsCurrent, CharacterBaseCharacteristic Initiative, CharacterBaseCharacteristic Prospecting, CharacterBaseCharacteristic ActionPoints, CharacterBaseCharacteristic MovementPoints, CharacterBaseCharacteristic Strength, CharacterBaseCharacteristic Vitality, CharacterBaseCharacteristic Wisdom, CharacterBaseCharacteristic Chance, CharacterBaseCharacteristic Agility, CharacterBaseCharacteristic Intelligence, CharacterBaseCharacteristic Range, CharacterBaseCharacteristic SummonableCreaturesBoost, CharacterBaseCharacteristic Reflect, CharacterBaseCharacteristic CriticalHit, short CriticalHitWeapon, CharacterBaseCharacteristic CriticalMiss, CharacterBaseCharacteristic HealBonus, CharacterBaseCharacteristic AllDamagesBonus, CharacterBaseCharacteristic WeaponDamagesBonusPercent, CharacterBaseCharacteristic DamagesBonusPercent, CharacterBaseCharacteristic TrapBonus, CharacterBaseCharacteristic TrapBonusPercent, CharacterBaseCharacteristic GlyphBonusPercent, CharacterBaseCharacteristic RuneBonusPercent, CharacterBaseCharacteristic PermanentDamagePercent, CharacterBaseCharacteristic TackleBlock, CharacterBaseCharacteristic TackleEvade, CharacterBaseCharacteristic PAAttack, CharacterBaseCharacteristic PMAttack, CharacterBaseCharacteristic PushDamageBonus, CharacterBaseCharacteristic CriticalDamageBonus, CharacterBaseCharacteristic NeutralDamageBonus, CharacterBaseCharacteristic EarthDamageBonus, CharacterBaseCharacteristic WaterDamageBonus, CharacterBaseCharacteristic AirDamageBonus, CharacterBaseCharacteristic FireDamageBonus, CharacterBaseCharacteristic DodgePALostProbability, CharacterBaseCharacteristic DodgePMLostProbability, CharacterBaseCharacteristic NeutralElementResistPercent, CharacterBaseCharacteristic EarthElementResistPercent, CharacterBaseCharacteristic WaterElementResistPercent, CharacterBaseCharacteristic AirElementResistPercent, CharacterBaseCharacteristic FireElementResistPercent, CharacterBaseCharacteristic NeutralElementReduction, CharacterBaseCharacteristic EarthElementReduction, CharacterBaseCharacteristic WaterElementReduction, CharacterBaseCharacteristic AirElementReduction, CharacterBaseCharacteristic FireElementReduction, CharacterBaseCharacteristic PushDamageReduction, CharacterBaseCharacteristic CriticalDamageReduction, CharacterBaseCharacteristic PvpNeutralElementResistPercent, CharacterBaseCharacteristic PvpEarthElementResistPercent, CharacterBaseCharacteristic PvpWaterElementResistPercent, CharacterBaseCharacteristic PvpAirElementResistPercent, CharacterBaseCharacteristic PvpFireElementResistPercent, CharacterBaseCharacteristic PvpNeutralElementReduction, CharacterBaseCharacteristic PvpEarthElementReduction, CharacterBaseCharacteristic PvpWaterElementReduction, CharacterBaseCharacteristic PvpAirElementReduction, CharacterBaseCharacteristic PvpFireElementReduction, CharacterBaseCharacteristic MeleeDamageDonePercent, CharacterBaseCharacteristic MeleeDamageReceivedPercent, CharacterBaseCharacteristic RangedDamageDonePercent, CharacterBaseCharacteristic RangedDamageReceivedPercent, CharacterBaseCharacteristic WeaponDamageDonePercent, CharacterBaseCharacteristic WeaponDamageReceivedPercent, CharacterBaseCharacteristic SpellDamageDonePercent, CharacterBaseCharacteristic SpellDamageReceivedPercent, CharacterSpellModification[] SpellModifications, int ProbationTime)
	{
		this.Experience = Experience;
		this.ExperienceLevelFloor = ExperienceLevelFloor;
		this.ExperienceNextLevelFloor = ExperienceNextLevelFloor;
		this.ExperienceBonusLimit = ExperienceBonusLimit;
		this.Kamas = Kamas;
		this.StatsPoints = StatsPoints;
		this.AdditionnalPoints = AdditionnalPoints;
		this.SpellsPoints = SpellsPoints;
		this.AlignmentInfos = AlignmentInfos;
		this.LifePoints = LifePoints;
		this.MaxLifePoints = MaxLifePoints;
		this.EnergyPoints = EnergyPoints;
		this.MaxEnergyPoints = MaxEnergyPoints;
		this.ActionPointsCurrent = ActionPointsCurrent;
		this.MovementPointsCurrent = MovementPointsCurrent;
		this.Initiative = Initiative;
		this.Prospecting = Prospecting;
		this.ActionPoints = ActionPoints;
		this.MovementPoints = MovementPoints;
		this.Strength = Strength;
		this.Vitality = Vitality;
		this.Wisdom = Wisdom;
		this.Chance = Chance;
		this.Agility = Agility;
		this.Intelligence = Intelligence;
		this.Range = Range;
		this.SummonableCreaturesBoost = SummonableCreaturesBoost;
		this.Reflect = Reflect;
		this.CriticalHit = CriticalHit;
		this.CriticalHitWeapon = CriticalHitWeapon;
		this.CriticalMiss = CriticalMiss;
		this.HealBonus = HealBonus;
		this.AllDamagesBonus = AllDamagesBonus;
		this.WeaponDamagesBonusPercent = WeaponDamagesBonusPercent;
		this.DamagesBonusPercent = DamagesBonusPercent;
		this.TrapBonus = TrapBonus;
		this.TrapBonusPercent = TrapBonusPercent;
		this.GlyphBonusPercent = GlyphBonusPercent;
		this.RuneBonusPercent = RuneBonusPercent;
		this.PermanentDamagePercent = PermanentDamagePercent;
		this.TackleBlock = TackleBlock;
		this.TackleEvade = TackleEvade;
		this.PAAttack = PAAttack;
		this.PMAttack = PMAttack;
		this.PushDamageBonus = PushDamageBonus;
		this.CriticalDamageBonus = CriticalDamageBonus;
		this.NeutralDamageBonus = NeutralDamageBonus;
		this.EarthDamageBonus = EarthDamageBonus;
		this.WaterDamageBonus = WaterDamageBonus;
		this.AirDamageBonus = AirDamageBonus;
		this.FireDamageBonus = FireDamageBonus;
		this.DodgePALostProbability = DodgePALostProbability;
		this.DodgePMLostProbability = DodgePMLostProbability;
		this.NeutralElementResistPercent = NeutralElementResistPercent;
		this.EarthElementResistPercent = EarthElementResistPercent;
		this.WaterElementResistPercent = WaterElementResistPercent;
		this.AirElementResistPercent = AirElementResistPercent;
		this.FireElementResistPercent = FireElementResistPercent;
		this.NeutralElementReduction = NeutralElementReduction;
		this.EarthElementReduction = EarthElementReduction;
		this.WaterElementReduction = WaterElementReduction;
		this.AirElementReduction = AirElementReduction;
		this.FireElementReduction = FireElementReduction;
		this.PushDamageReduction = PushDamageReduction;
		this.CriticalDamageReduction = CriticalDamageReduction;
		this.PvpNeutralElementResistPercent = PvpNeutralElementResistPercent;
		this.PvpEarthElementResistPercent = PvpEarthElementResistPercent;
		this.PvpWaterElementResistPercent = PvpWaterElementResistPercent;
		this.PvpAirElementResistPercent = PvpAirElementResistPercent;
		this.PvpFireElementResistPercent = PvpFireElementResistPercent;
		this.PvpNeutralElementReduction = PvpNeutralElementReduction;
		this.PvpEarthElementReduction = PvpEarthElementReduction;
		this.PvpWaterElementReduction = PvpWaterElementReduction;
		this.PvpAirElementReduction = PvpAirElementReduction;
		this.PvpFireElementReduction = PvpFireElementReduction;
		this.MeleeDamageDonePercent = MeleeDamageDonePercent;
		this.MeleeDamageReceivedPercent = MeleeDamageReceivedPercent;
		this.RangedDamageDonePercent = RangedDamageDonePercent;
		this.RangedDamageReceivedPercent = RangedDamageReceivedPercent;
		this.WeaponDamageDonePercent = WeaponDamageDonePercent;
		this.WeaponDamageReceivedPercent = WeaponDamageReceivedPercent;
		this.SpellDamageDonePercent = SpellDamageDonePercent;
		this.SpellDamageReceivedPercent = SpellDamageReceivedPercent;
		this.SpellModifications = SpellModifications;
		this.ProbationTime = ProbationTime;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.Experience);
		writer.WriteVarLong(this.ExperienceLevelFloor);
		writer.WriteVarLong(this.ExperienceNextLevelFloor);
		writer.WriteVarLong(this.ExperienceBonusLimit);
		writer.WriteVarLong(this.Kamas);
		writer.WriteVarShort(this.StatsPoints);
		writer.WriteVarShort(this.AdditionnalPoints);
		writer.WriteVarShort(this.SpellsPoints);
		this.AlignmentInfos.Serialize(writer);
		writer.WriteVarInt(this.LifePoints);
		writer.WriteVarInt(this.MaxLifePoints);
		writer.WriteVarShort(this.EnergyPoints);
		writer.WriteVarShort(this.MaxEnergyPoints);
		writer.WriteVarShort(this.ActionPointsCurrent);
		writer.WriteVarShort(this.MovementPointsCurrent);
		this.Initiative.Serialize(writer);
		this.Prospecting.Serialize(writer);
		this.ActionPoints.Serialize(writer);
		this.MovementPoints.Serialize(writer);
		this.Strength.Serialize(writer);
		this.Vitality.Serialize(writer);
		this.Wisdom.Serialize(writer);
		this.Chance.Serialize(writer);
		this.Agility.Serialize(writer);
		this.Intelligence.Serialize(writer);
		this.Range.Serialize(writer);
		this.SummonableCreaturesBoost.Serialize(writer);
		this.Reflect.Serialize(writer);
		this.CriticalHit.Serialize(writer);
		writer.WriteVarShort(this.CriticalHitWeapon);
		this.CriticalMiss.Serialize(writer);
		this.HealBonus.Serialize(writer);
		this.AllDamagesBonus.Serialize(writer);
		this.WeaponDamagesBonusPercent.Serialize(writer);
		this.DamagesBonusPercent.Serialize(writer);
		this.TrapBonus.Serialize(writer);
		this.TrapBonusPercent.Serialize(writer);
		this.GlyphBonusPercent.Serialize(writer);
		this.RuneBonusPercent.Serialize(writer);
		this.PermanentDamagePercent.Serialize(writer);
		this.TackleBlock.Serialize(writer);
		this.TackleEvade.Serialize(writer);
		this.PAAttack.Serialize(writer);
		this.PMAttack.Serialize(writer);
		this.PushDamageBonus.Serialize(writer);
		this.CriticalDamageBonus.Serialize(writer);
		this.NeutralDamageBonus.Serialize(writer);
		this.EarthDamageBonus.Serialize(writer);
		this.WaterDamageBonus.Serialize(writer);
		this.AirDamageBonus.Serialize(writer);
		this.FireDamageBonus.Serialize(writer);
		this.DodgePALostProbability.Serialize(writer);
		this.DodgePMLostProbability.Serialize(writer);
		this.NeutralElementResistPercent.Serialize(writer);
		this.EarthElementResistPercent.Serialize(writer);
		this.WaterElementResistPercent.Serialize(writer);
		this.AirElementResistPercent.Serialize(writer);
		this.FireElementResistPercent.Serialize(writer);
		this.NeutralElementReduction.Serialize(writer);
		this.EarthElementReduction.Serialize(writer);
		this.WaterElementReduction.Serialize(writer);
		this.AirElementReduction.Serialize(writer);
		this.FireElementReduction.Serialize(writer);
		this.PushDamageReduction.Serialize(writer);
		this.CriticalDamageReduction.Serialize(writer);
		this.PvpNeutralElementResistPercent.Serialize(writer);
		this.PvpEarthElementResistPercent.Serialize(writer);
		this.PvpWaterElementResistPercent.Serialize(writer);
		this.PvpAirElementResistPercent.Serialize(writer);
		this.PvpFireElementResistPercent.Serialize(writer);
		this.PvpNeutralElementReduction.Serialize(writer);
		this.PvpEarthElementReduction.Serialize(writer);
		this.PvpWaterElementReduction.Serialize(writer);
		this.PvpAirElementReduction.Serialize(writer);
		this.PvpFireElementReduction.Serialize(writer);
		this.MeleeDamageDonePercent.Serialize(writer);
		this.MeleeDamageReceivedPercent.Serialize(writer);
		this.RangedDamageDonePercent.Serialize(writer);
		this.RangedDamageReceivedPercent.Serialize(writer);
		this.WeaponDamageDonePercent.Serialize(writer);
		this.WeaponDamageReceivedPercent.Serialize(writer);
		this.SpellDamageDonePercent.Serialize(writer);
		this.SpellDamageReceivedPercent.Serialize(writer);
		writer.WriteShort(this.SpellModifications.Length);
		foreach (CharacterSpellModification item in this.SpellModifications)
		{
			item.Serialize(writer);
		}
		writer.WriteInt(this.ProbationTime);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Experience = reader.ReadVarLong();
		this.ExperienceLevelFloor = reader.ReadVarLong();
		this.ExperienceNextLevelFloor = reader.ReadVarLong();
		this.ExperienceBonusLimit = reader.ReadVarLong();
		this.Kamas = reader.ReadVarLong();
		this.StatsPoints = reader.ReadVarShort();
		this.AdditionnalPoints = reader.ReadVarShort();
		this.SpellsPoints = reader.ReadVarShort();
		this.AlignmentInfos = new ActorExtendedAlignmentInformations();
		this.AlignmentInfos.Deserialize(reader);
		this.LifePoints = reader.ReadVarInt();
		this.MaxLifePoints = reader.ReadVarInt();
		this.EnergyPoints = reader.ReadVarShort();
		this.MaxEnergyPoints = reader.ReadVarShort();
		this.ActionPointsCurrent = reader.ReadVarShort();
		this.MovementPointsCurrent = reader.ReadVarShort();
		this.Initiative = new CharacterBaseCharacteristic();
		this.Initiative.Deserialize(reader);
		this.Prospecting = new CharacterBaseCharacteristic();
		this.Prospecting.Deserialize(reader);
		this.ActionPoints = new CharacterBaseCharacteristic();
		this.ActionPoints.Deserialize(reader);
		this.MovementPoints = new CharacterBaseCharacteristic();
		this.MovementPoints.Deserialize(reader);
		this.Strength = new CharacterBaseCharacteristic();
		this.Strength.Deserialize(reader);
		this.Vitality = new CharacterBaseCharacteristic();
		this.Vitality.Deserialize(reader);
		this.Wisdom = new CharacterBaseCharacteristic();
		this.Wisdom.Deserialize(reader);
		this.Chance = new CharacterBaseCharacteristic();
		this.Chance.Deserialize(reader);
		this.Agility = new CharacterBaseCharacteristic();
		this.Agility.Deserialize(reader);
		this.Intelligence = new CharacterBaseCharacteristic();
		this.Intelligence.Deserialize(reader);
		this.Range = new CharacterBaseCharacteristic();
		this.Range.Deserialize(reader);
		this.SummonableCreaturesBoost = new CharacterBaseCharacteristic();
		this.SummonableCreaturesBoost.Deserialize(reader);
		this.Reflect = new CharacterBaseCharacteristic();
		this.Reflect.Deserialize(reader);
		this.CriticalHit = new CharacterBaseCharacteristic();
		this.CriticalHit.Deserialize(reader);
		this.CriticalHitWeapon = reader.ReadVarShort();
		this.CriticalMiss = new CharacterBaseCharacteristic();
		this.CriticalMiss.Deserialize(reader);
		this.HealBonus = new CharacterBaseCharacteristic();
		this.HealBonus.Deserialize(reader);
		this.AllDamagesBonus = new CharacterBaseCharacteristic();
		this.AllDamagesBonus.Deserialize(reader);
		this.WeaponDamagesBonusPercent = new CharacterBaseCharacteristic();
		this.WeaponDamagesBonusPercent.Deserialize(reader);
		this.DamagesBonusPercent = new CharacterBaseCharacteristic();
		this.DamagesBonusPercent.Deserialize(reader);
		this.TrapBonus = new CharacterBaseCharacteristic();
		this.TrapBonus.Deserialize(reader);
		this.TrapBonusPercent = new CharacterBaseCharacteristic();
		this.TrapBonusPercent.Deserialize(reader);
		this.GlyphBonusPercent = new CharacterBaseCharacteristic();
		this.GlyphBonusPercent.Deserialize(reader);
		this.RuneBonusPercent = new CharacterBaseCharacteristic();
		this.RuneBonusPercent.Deserialize(reader);
		this.PermanentDamagePercent = new CharacterBaseCharacteristic();
		this.PermanentDamagePercent.Deserialize(reader);
		this.TackleBlock = new CharacterBaseCharacteristic();
		this.TackleBlock.Deserialize(reader);
		this.TackleEvade = new CharacterBaseCharacteristic();
		this.TackleEvade.Deserialize(reader);
		this.PAAttack = new CharacterBaseCharacteristic();
		this.PAAttack.Deserialize(reader);
		this.PMAttack = new CharacterBaseCharacteristic();
		this.PMAttack.Deserialize(reader);
		this.PushDamageBonus = new CharacterBaseCharacteristic();
		this.PushDamageBonus.Deserialize(reader);
		this.CriticalDamageBonus = new CharacterBaseCharacteristic();
		this.CriticalDamageBonus.Deserialize(reader);
		this.NeutralDamageBonus = new CharacterBaseCharacteristic();
		this.NeutralDamageBonus.Deserialize(reader);
		this.EarthDamageBonus = new CharacterBaseCharacteristic();
		this.EarthDamageBonus.Deserialize(reader);
		this.WaterDamageBonus = new CharacterBaseCharacteristic();
		this.WaterDamageBonus.Deserialize(reader);
		this.AirDamageBonus = new CharacterBaseCharacteristic();
		this.AirDamageBonus.Deserialize(reader);
		this.FireDamageBonus = new CharacterBaseCharacteristic();
		this.FireDamageBonus.Deserialize(reader);
		this.DodgePALostProbability = new CharacterBaseCharacteristic();
		this.DodgePALostProbability.Deserialize(reader);
		this.DodgePMLostProbability = new CharacterBaseCharacteristic();
		this.DodgePMLostProbability.Deserialize(reader);
		this.NeutralElementResistPercent = new CharacterBaseCharacteristic();
		this.NeutralElementResistPercent.Deserialize(reader);
		this.EarthElementResistPercent = new CharacterBaseCharacteristic();
		this.EarthElementResistPercent.Deserialize(reader);
		this.WaterElementResistPercent = new CharacterBaseCharacteristic();
		this.WaterElementResistPercent.Deserialize(reader);
		this.AirElementResistPercent = new CharacterBaseCharacteristic();
		this.AirElementResistPercent.Deserialize(reader);
		this.FireElementResistPercent = new CharacterBaseCharacteristic();
		this.FireElementResistPercent.Deserialize(reader);
		this.NeutralElementReduction = new CharacterBaseCharacteristic();
		this.NeutralElementReduction.Deserialize(reader);
		this.EarthElementReduction = new CharacterBaseCharacteristic();
		this.EarthElementReduction.Deserialize(reader);
		this.WaterElementReduction = new CharacterBaseCharacteristic();
		this.WaterElementReduction.Deserialize(reader);
		this.AirElementReduction = new CharacterBaseCharacteristic();
		this.AirElementReduction.Deserialize(reader);
		this.FireElementReduction = new CharacterBaseCharacteristic();
		this.FireElementReduction.Deserialize(reader);
		this.PushDamageReduction = new CharacterBaseCharacteristic();
		this.PushDamageReduction.Deserialize(reader);
		this.CriticalDamageReduction = new CharacterBaseCharacteristic();
		this.CriticalDamageReduction.Deserialize(reader);
		this.PvpNeutralElementResistPercent = new CharacterBaseCharacteristic();
		this.PvpNeutralElementResistPercent.Deserialize(reader);
		this.PvpEarthElementResistPercent = new CharacterBaseCharacteristic();
		this.PvpEarthElementResistPercent.Deserialize(reader);
		this.PvpWaterElementResistPercent = new CharacterBaseCharacteristic();
		this.PvpWaterElementResistPercent.Deserialize(reader);
		this.PvpAirElementResistPercent = new CharacterBaseCharacteristic();
		this.PvpAirElementResistPercent.Deserialize(reader);
		this.PvpFireElementResistPercent = new CharacterBaseCharacteristic();
		this.PvpFireElementResistPercent.Deserialize(reader);
		this.PvpNeutralElementReduction = new CharacterBaseCharacteristic();
		this.PvpNeutralElementReduction.Deserialize(reader);
		this.PvpEarthElementReduction = new CharacterBaseCharacteristic();
		this.PvpEarthElementReduction.Deserialize(reader);
		this.PvpWaterElementReduction = new CharacterBaseCharacteristic();
		this.PvpWaterElementReduction.Deserialize(reader);
		this.PvpAirElementReduction = new CharacterBaseCharacteristic();
		this.PvpAirElementReduction.Deserialize(reader);
		this.PvpFireElementReduction = new CharacterBaseCharacteristic();
		this.PvpFireElementReduction.Deserialize(reader);
		this.MeleeDamageDonePercent = new CharacterBaseCharacteristic();
		this.MeleeDamageDonePercent.Deserialize(reader);
		this.MeleeDamageReceivedPercent = new CharacterBaseCharacteristic();
		this.MeleeDamageReceivedPercent.Deserialize(reader);
		this.RangedDamageDonePercent = new CharacterBaseCharacteristic();
		this.RangedDamageDonePercent.Deserialize(reader);
		this.RangedDamageReceivedPercent = new CharacterBaseCharacteristic();
		this.RangedDamageReceivedPercent.Deserialize(reader);
		this.WeaponDamageDonePercent = new CharacterBaseCharacteristic();
		this.WeaponDamageDonePercent.Deserialize(reader);
		this.WeaponDamageReceivedPercent = new CharacterBaseCharacteristic();
		this.WeaponDamageReceivedPercent.Deserialize(reader);
		this.SpellDamageDonePercent = new CharacterBaseCharacteristic();
		this.SpellDamageDonePercent.Deserialize(reader);
		this.SpellDamageReceivedPercent = new CharacterBaseCharacteristic();
		this.SpellDamageReceivedPercent.Deserialize(reader);
		int SpellModificationsLen = reader.ReadShort();
		SpellModifications = new CharacterSpellModification[SpellModificationsLen];
		for (int i = 0; i < SpellModificationsLen; i++)
		{
			this.SpellModifications[i] = new CharacterSpellModification();
			this.SpellModifications[i].Deserialize(reader);
		}
		this.ProbationTime = reader.ReadInt();
	}
}
}
