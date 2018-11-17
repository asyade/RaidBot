using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayGroupMonsterInformations : GameRolePlayActorInformations
{

	public const uint Id = 160;
	public override uint MessageId { get { return Id; } }

	public bool KeyRingBonus { get; set; }
	public bool HasHardcoreDrop { get; set; }
	public bool HasAVARewardToken { get; set; }
	public double CreationTime { get; set; }
	public int AgeBonusRate { get; set; }
	public byte LootShare { get; set; }
	public byte AlignmentSide { get; set; }

	public GameRolePlayGroupMonsterInformations() {}


	public GameRolePlayGroupMonsterInformations InitGameRolePlayGroupMonsterInformations(bool KeyRingBonus, bool HasHardcoreDrop, bool HasAVARewardToken, double CreationTime, int AgeBonusRate, byte LootShare, byte AlignmentSide)
	{
		this.KeyRingBonus = KeyRingBonus;
		this.HasHardcoreDrop = HasHardcoreDrop;
		this.HasAVARewardToken = HasAVARewardToken;
		this.CreationTime = CreationTime;
		this.AgeBonusRate = AgeBonusRate;
		this.LootShare = LootShare;
		this.AlignmentSide = AlignmentSide;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, KeyRingBonus);
		box = BooleanByteWrapper.SetFlag(box, 1, HasHardcoreDrop);
		box = BooleanByteWrapper.SetFlag(box, 2, HasAVARewardToken);
		writer.WriteByte(box);
		writer.WriteDouble(this.CreationTime);
		writer.WriteInt(this.AgeBonusRate);
		writer.WriteByte(this.LootShare);
		writer.WriteByte(this.AlignmentSide);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		byte box = reader.ReadByte();
		this.KeyRingBonus = BooleanByteWrapper.GetFlag(box, 0);
		this.HasHardcoreDrop = BooleanByteWrapper.GetFlag(box, 1);
		this.HasAVARewardToken = BooleanByteWrapper.GetFlag(box, 2);
		this.CreationTime = reader.ReadDouble();
		this.AgeBonusRate = reader.ReadInt();
		this.LootShare = reader.ReadByte();
		this.AlignmentSide = reader.ReadByte();
	}
}
}
