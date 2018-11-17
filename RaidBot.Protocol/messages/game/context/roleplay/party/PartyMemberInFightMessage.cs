using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyMemberInFightMessage : AbstractPartyMessage
{

	public const uint Id = 6342;
	public override uint MessageId { get { return Id; } }

	public byte Reason { get; set; }
	public long MemberId { get; set; }
	public int MemberAccountId { get; set; }
	public String MemberName { get; set; }
	public short FightId { get; set; }
	public MapCoordinatesExtended FightMap { get; set; }
	public short TimeBeforeFightStart { get; set; }

	public PartyMemberInFightMessage() {}


	public PartyMemberInFightMessage InitPartyMemberInFightMessage(byte Reason, long MemberId, int MemberAccountId, String MemberName, short FightId, MapCoordinatesExtended FightMap, short TimeBeforeFightStart)
	{
		this.Reason = Reason;
		this.MemberId = MemberId;
		this.MemberAccountId = MemberAccountId;
		this.MemberName = MemberName;
		this.FightId = FightId;
		this.FightMap = FightMap;
		this.TimeBeforeFightStart = TimeBeforeFightStart;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.Reason);
		writer.WriteVarLong(this.MemberId);
		writer.WriteInt(this.MemberAccountId);
		writer.WriteUTF(this.MemberName);
		writer.WriteVarShort(this.FightId);
		this.FightMap.Serialize(writer);
		writer.WriteVarShort(this.TimeBeforeFightStart);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Reason = reader.ReadByte();
		this.MemberId = reader.ReadVarLong();
		this.MemberAccountId = reader.ReadInt();
		this.MemberName = reader.ReadUTF();
		this.FightId = reader.ReadVarShort();
		this.FightMap = new MapCoordinatesExtended();
		this.FightMap.Deserialize(reader);
		this.TimeBeforeFightStart = reader.ReadVarShort();
	}
}
}
