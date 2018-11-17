using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FriendSpouseOnlineInformations : FriendSpouseInformations
{

	public const uint Id = 93;
	public override uint MessageId { get { return Id; } }

	public bool InFight { get; set; }
	public bool FollowSpouse { get; set; }
	public double MapId { get; set; }
	public short SubAreaId { get; set; }

	public FriendSpouseOnlineInformations() {}


	public FriendSpouseOnlineInformations InitFriendSpouseOnlineInformations(bool InFight, bool FollowSpouse, double MapId, short SubAreaId)
	{
		this.InFight = InFight;
		this.FollowSpouse = FollowSpouse;
		this.MapId = MapId;
		this.SubAreaId = SubAreaId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, InFight);
		box = BooleanByteWrapper.SetFlag(box, 1, FollowSpouse);
		writer.WriteByte(box);
		writer.WriteDouble(this.MapId);
		writer.WriteVarShort(this.SubAreaId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		byte box = reader.ReadByte();
		this.InFight = BooleanByteWrapper.GetFlag(box, 0);
		this.FollowSpouse = BooleanByteWrapper.GetFlag(box, 1);
		this.MapId = reader.ReadDouble();
		this.SubAreaId = reader.ReadVarShort();
	}
}
}
