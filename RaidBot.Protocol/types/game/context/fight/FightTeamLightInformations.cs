using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightTeamLightInformations : AbstractFightTeamInformations
{

	public const uint Id = 115;
	public override uint MessageId { get { return Id; } }

	public bool HasFriend { get; set; }
	public bool HasGuildMember { get; set; }
	public bool HasAllianceMember { get; set; }
	public bool HasGroupMember { get; set; }
	public bool HasMyTaxCollector { get; set; }
	public byte TeamMembersCount { get; set; }
	public int MeanLevel { get; set; }

	public FightTeamLightInformations() {}


	public FightTeamLightInformations InitFightTeamLightInformations(bool HasFriend, bool HasGuildMember, bool HasAllianceMember, bool HasGroupMember, bool HasMyTaxCollector, byte TeamMembersCount, int MeanLevel)
	{
		this.HasFriend = HasFriend;
		this.HasGuildMember = HasGuildMember;
		this.HasAllianceMember = HasAllianceMember;
		this.HasGroupMember = HasGroupMember;
		this.HasMyTaxCollector = HasMyTaxCollector;
		this.TeamMembersCount = TeamMembersCount;
		this.MeanLevel = MeanLevel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, HasFriend);
		box = BooleanByteWrapper.SetFlag(box, 1, HasGuildMember);
		box = BooleanByteWrapper.SetFlag(box, 2, HasAllianceMember);
		box = BooleanByteWrapper.SetFlag(box, 3, HasGroupMember);
		box = BooleanByteWrapper.SetFlag(box, 4, HasMyTaxCollector);
		writer.WriteByte(box);
		writer.WriteByte(this.TeamMembersCount);
		writer.WriteVarInt(this.MeanLevel);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		byte box = reader.ReadByte();
		this.HasFriend = BooleanByteWrapper.GetFlag(box, 0);
		this.HasGuildMember = BooleanByteWrapper.GetFlag(box, 1);
		this.HasAllianceMember = BooleanByteWrapper.GetFlag(box, 2);
		this.HasGroupMember = BooleanByteWrapper.GetFlag(box, 3);
		this.HasMyTaxCollector = BooleanByteWrapper.GetFlag(box, 4);
		this.TeamMembersCount = reader.ReadByte();
		this.MeanLevel = reader.ReadVarInt();
	}
}
}
